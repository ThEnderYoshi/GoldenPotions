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

        public override void SetDefaults()
        {
            Projectile.CloneDefaults(ProjectileID.FoulPotion);
            AIType = ProjectileID.FoulPotion;
        }

        public override void OnKill(int timeLeft)
        {
            SoundEngine.PlaySound(SoundID.Shatter, Projectile.position);
            // Item16 - Fart sound.
            SoundEngine.PlaySound(SoundID.Item16, Projectile.position);

            for (int i = 0; i < 5; i++)
            {
                Dust.NewDust(
                    Projectile.position,
                    Projectile.width,
                    Projectile.height,
                    DustID.Glass);
            }

            for (int i = 0; i < 25; i++)
            {
                var direction = new Vector2(Main.rand.Next(-10, 11), Main.rand.Next(-10, 11));
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

            InflictBuff();
        }

        private void InflictBuff()
        {
            if (Projectile.owner == Main.myPlayer)
            {
                const int BuffTime = 60 * 60;
                const float Radius = 80f;
                int buffID = ModContent.BuffType<GoldenStink>();

                for (int i = 0; i < Main.maxPlayers; i++)
                {
                    Player player = Main.player[i];
                    float distance = Vector2.Distance(Projectile.Center, player.Center);

                    if (player.active && !player.dead && distance < Radius)
                    {
                        player.AddBuff(buffID, BuffTime);
                    }
                }

                for (int i = 0; i < Main.maxNPCs; i++)
                {
                    NPC npc = Main.npc[i];
                    float distance = Vector2.Distance(Projectile.Center, npc.Center);

                    if (npc.active && npc.life > 0 && distance < Radius)
                    {
                        npc.AddBuff(buffID, BuffTime);
                    }
                }
            }
        }
    }
}
