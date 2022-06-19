using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Projectiles
{
    internal class GoldenLovePotionProj : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Golden Love Potion");
        }

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.LovePotion);
            AIType = ProjectileID.LovePotion;
        }

        public override void Kill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Item4, Projectile.position);

            // Spawn dusts
            for (int i = 0; i < 5; i++)
            {
                Dust.NewDust(Projectile.position, Projectile.width, Projectile.height, DustID.Glass);
            }
            // Spawn gores
            for (int i = 0; i < 25; i++)
            {
                Vector2 direction = new Vector2(Main.rand.Next(-10, 11), Main.rand.Next(-10, 11));
                direction.Normalize();
                int gore = Gore.NewGore(
                    Projectile.GetSource_Death(),
                    Projectile.Center + direction * 10f,
                    direction * Main.rand.Next(4, 9) * 0.66f + Vector2.UnitY * 1.5f,
                    331, Main.rand.Next(40, 141) * 0.01f); // 331 == Lovestruck/Rapid Healing gore ID (not listed in GoreID)

                Main.gore[gore].sticky = false;
            }

            // Inflict Lovestruck++ to...
            if (Projectile.owner == Main.myPlayer)
            {
                const int BuffTime = 1800; // 30 seconds
                const float Radius = 80f;
                int buffID = ModContent.BuffType<GoldenLove>();

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
