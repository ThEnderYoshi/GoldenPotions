using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Projectiles
{
    internal class GoldenStinkPotionProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Stink Potion");
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.FoulPotion);
            AIType = ProjectileID.FoulPotion;
        }

        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.position);
            SoundEngine.PlaySound(SoundID.Item16, Projectile.position);

            // Dusts
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Glass);
            }
            // Gores
            for (int i = 0; i < 25; i++)
            {
                Vector2 direction = new Vector2(Main.rand.Next(-10, 11), Main.rand.Next(-10, 11));
                direction.Normalize();
                direction *= 0.4f;
                int gore = Gore.NewGore(
                    Projectile.GetSource_Death(),
                    Projectile.Center + direction * 38f,
                    direction * Main.rand.Next(4, 9) * 0.66f + Vector2.UnitY * 1.5f,
                    Main.rand.Next(436, 438),
                    Main.rand.Next(20, 100) * 0.01f);
                Main.gore[gore].sticky = false;
            }

            // Inflict Stinky-- to...
            if (Projectile.owner == Main.myPlayer)
            {
                const int BuffTime = 3600; // 1 minute
                const float Radius = 80f;
                int buffID = ModContent.BuffType<GoldenStink>();

                // ...players
                for (int i = 0; i < 255; i++)
                {
                    Player player = Main.player[i];
                    if (player.active && !player.dead && Vector2.Distance(Projectile.Center, player.Center) < Radius)
                    {
                        player.AddBuff(buffID, BuffTime);
                    }
                }
                // ...NPCs
                for (int i = 0; i < 200; i++)
                {
                    NPC npc = Main.npc[i];
                    if (npc.active && npc.life > 0 && Vector2.Distance(Projectile.Center, npc.Center) < Radius)
                    {
                        npc.AddBuff(buffID, BuffTime);
                    }
                }
            }
        }
    }
}
