using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
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
            Description.SetDefault("Nearby enemies are ignited with hellfire");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            //player.inferno = true; // <-- Evil >:3
            player.GetModPlayer<GoldenPotionsPlayer>().goldenInferno = true;

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
                        if (!target.HasBuff(BuffID.OnFire3))
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

    internal class GoldenInfernoPlayer : ModPlayer
    {
        private float ringRot;
        private float ringScale = 1f;
        private Asset<Texture2D> ringTexture;

        public override void DrawEffects(PlayerDrawSet drawInfo, ref float r, ref float g, ref float b, ref float a, ref bool fullBright)
        {
            if (Player.GetModPlayer<GoldenPotionsPlayer>().goldenInferno)
            {
                DrawRing();
            }
        }

        private void LoadRing()
        {
            if (ringTexture == null)
            {
                ringTexture = ModContent.Request<Texture2D>("GoldenPotions/Buffs/GoldenInferno_Ring");
            }
        }

        private void DrawRing()
        {
            LoadRing();

            float scale = 1f;
            float num2 = 0.1f;
            float num3 = 0.9f;

            // Scale
            if (!Main.gamePaused) { ringScale += 0.004f; }
            if (ringScale < 1f) { scale = ringScale; }
            else
            {
                ringScale = 0.8f;
                scale = ringScale;
            }

            // Rotation
            if (!Main.gamePaused) { ringRot += 0.05f; }
            if (ringRot > MathHelper.TwoPi) { ringRot -= MathHelper.TwoPi; }
            if (ringRot < -MathHelper.TwoPi) { ringRot += MathHelper.TwoPi; }

            // Draw rings
            for (int i = 0; i < 3; i++)
            {
                float finalScale = scale + num2 * i;
                if (finalScale > 1f) { finalScale -= num2 * 2f; }
                float col = MathHelper.Lerp(0.8f, 0f, Math.Abs(finalScale - num3) * 10f);

                Main.spriteBatch.Draw(
                    ringTexture.Value,
                    Player.Center - Main.screenPosition,
                    new Rectangle(0, 400 * i, 400, 400),
                    new Color(col, col, col, col / 2f),
                    ringRot + MathHelper.Pi / 3f * i,
                    new Vector2(200f),
                    finalScale,
                    SpriteEffects.None,
                    0f);
            }
        }
    }
}
