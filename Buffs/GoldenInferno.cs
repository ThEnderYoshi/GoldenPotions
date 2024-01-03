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
        public override int OverwriteBuff => BuffID.Inferno;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>().goldenInferno = true;

            const int damage = 10;
            const float maxDist = 200f;
            bool shouldApplyDamage = player.GetModPlayer<GoldenPotionsPlayer>()
                .goldenInfernoCounter % 60 == 0;

            Lighting.AddLight(
                (int)(player.position.X / 16f),
                (int)(player.position.Y / 16f),
                0.9f,
                0.8f,
                0.2f);

            if (player.whoAmI == Main.myPlayer)
            {
                DamageNPCs(player, damage, maxDist, shouldApplyDamage);
                DamagePlayers(player, damage, maxDist, shouldApplyDamage);
            }
        }

        private static void DamageNPCs(Player player, int damage, float maxDist, bool shouldApplyDamage)
        {
            for (int i = 0; i < 200; i++)
            {
                NPC target = Main.npc[i];

                if (!CanDamageNPC(player, maxDist, target))
                {
                    continue;
                }

                if (!target.HasBuff(BuffID.OnFire3))
                {
                    target.AddBuff(BuffID.OnFire3, 2 * 60);
                }

                if (shouldApplyDamage)
                {
                    player.ApplyDamageToNPC(target, damage, 0f, 0, false);
                }
            }
        }

        private static void DamagePlayers(Player player, int damage, float maxDist, bool shouldApplyDamage)
        {
            if (!player.hostile) return;

            for (int i = 0; i < 255; i++)
            {
                Player target = Main.player[i];

                if (!CanDamagePlayer(player, maxDist, target))
                {
                    continue;
                }

                if (player.HasBuff(BuffID.OnFire3))
                {
                    target.AddBuff(BuffID.OnFire3, 120); // 2 seconds
                }

                if (shouldApplyDamage)
                {
                    target.Hurt(PlayerDeathReason.LegacyEmpty(), damage, 0);

                    if (Main.netMode == NetmodeID.SinglePlayer)
                    {
                        continue;
                    }

                    var info = new Player.HurtInfo
                    {
                        Damage = damage,
                        DamageSource = PlayerDeathReason.ByOther(16),
                        PvP = true,
                        DustDisabled = true,
                    };
                    NetMessage.SendPlayerHurt(i, info);
                }
            }
        }

        private static bool CanDamageNPC(Player damager, float maxDist, NPC target)
        {
            return target.active
                && !target.friendly
                && target.damage > 0
                && !target.dontTakeDamage
                && !target.buffImmune[BuffID.OnFire3]
                //FIXME: Find alternative(?) to Player.this.CanNPCBeHitByPlayerOrPlayerProjectile
                && Vector2.Distance(damager.Center, target.Center) <= maxDist;
        }

        private static bool CanDamagePlayer(Player damager, float maxDist, Player target)
        {
            return target != damager
                && target.active
                && !target.dead
                && target.hostile
                && !target.buffImmune[BuffID.OnFire3]
                && (target.team != damager.team || target.team == 0)
                && Vector2.Distance(damager.Center, target.Center) <= maxDist;
        }
    }

    internal class GoldenInfernoPlayer : ModPlayer
    {
        private float ringRot;
        private float ringScale = 1f;
        private Asset<Texture2D> ringTexture;

        public override void DrawEffects(
            PlayerDrawSet drawInfo,
            ref float r,
            ref float g,
            ref float b,
            ref float a,
            ref bool fullBright)
        {
            if (Player.GetModPlayer<GoldenPotionsPlayer>().goldenInferno)
            {
                DrawRing();
            }
        }

        private void LoadRing()
        {
            ringTexture ??= ModContent.Request<Texture2D>("GoldenPotions/Buffs/GoldenInferno_Ring");
        }

        private void DrawRing()
        {
            LoadRing();

            float scale = 1f;
            float num2 = 0.1f;
            float num3 = 0.9f;

            // Scale
            if (!Main.gamePaused) {
                ringScale += 0.004f;
            }

            if (ringScale < 1f) {
                scale = ringScale;
            }
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
                if (finalScale > 1f) {
                    finalScale -= num2 * 2f;
                }
                float color = MathHelper.Lerp(0.8f, 0f, Math.Abs(finalScale - num3) * 10f);

                Main.spriteBatch.Draw(
                    ringTexture.Value,
                    Player.Center - Main.screenPosition,
                    new Rectangle(0, 400 * i, 400, 400),
                    new Color(color, color, color, color * 0.5f),
                    ringRot + MathHelper.Pi / 3f * i,
                    new Vector2(200f),
                    finalScale,
                    SpriteEffects.None,
                    layerDepth: 0f
                );
            }
        }
    }
}
