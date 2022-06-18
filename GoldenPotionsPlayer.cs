using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace GoldenPotions
{
    internal class GoldenPotionsPlayer : ModPlayer
    {
        public bool goldenAmmoReservation = false;
        public bool goldenArchery = false;

        public override void ResetEffects()
        {
            goldenAmmoReservation = false;
            goldenArchery = false;
        }

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            return !goldenAmmoReservation || Main.rand.NextFloat() > 0.4f;
        }

        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (goldenArchery)
            {
                velocity *= 1.4f;
                damage = (int) (damage * 1.4f);
            }
        }
    }
}
