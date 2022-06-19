using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;

namespace GoldenPotions.Buffs
{
    internal class GoldenInferno : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.Inferno; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Inferno++");
            Description.SetDefault("Nearby enemies are ignited");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            const int damage = 10;
            const float maxDist = 200f;
            bool flag = player.GetModPlayer<GoldenPotionsPlayer>().goldenInfernoCounter % 60 == 0;

            Lighting.AddLight((int)(player.position.X / 16f), (int)(player.position.Y / 16f), 0.65f, 0.4f, 0.1f);

            if (player.whoAmI == Main.myPlayer)
            {
                // Deal with NPCs
                for (int k = 0; k < 200; k++)
                {
                    NPC target = Main.npc[k];
                    if (target.active && !target.friendly && target.damage > 0
                            && !target.dontTakeDamage && !target.buffImmune[BuffID.OnFire3]
                            //FIXME: Find alternative(?) to Player.this.CanNPCBeHitByPlayerOrPlayerProjectile
                            && Vector2.Distance(player.Center, target.Center) <= maxDist)
                    {
                        if (target.HasBuff(BuffID.OnFire3))
                        {
                            target.AddBuff(BuffID.OnFire3, 120); // 2 seconds
                        }
                        if (flag)
                        {
                            player.ApplyDamageToNPC(target, damage, 0f, 0, false);
                        }
                    }
                }
                // Deal with PvP
                if (player.hostile)
                {
                    for (int l = 0; l < 255; l++)
                    {
                        Player target = Main.player[l];
                        if (target != player && target.active && !target.dead && target.hostile && !target.buffImmune[BuffID.OnFire3]
                                && (target.team != player.team || target.team == 0)
                                && Vector2.Distance(player.Center, target.Center) <= maxDist)
                        {
                            if (player.HasBuff(BuffID.OnFire3))
                            {
                                target.AddBuff(BuffID.OnFire3, 120); // 2 seconds
                            }
                            if (flag)
                            {
                                target.Hurt(PlayerDeathReason.LegacyEmpty(), damage, 0);
                                if (Main.netMode != NetmodeID.SinglePlayer)
                                {
                                    PlayerDeathReason reason = PlayerDeathReason.ByOther(16);
                                    NetMessage.SendPlayerHurt(l, reason, damage, 0, false, true, -1);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
