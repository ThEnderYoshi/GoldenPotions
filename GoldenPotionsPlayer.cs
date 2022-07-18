using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace GoldenPotions
{
    internal class GoldenPotionsPlayer : ModPlayer
    {
        public bool goldenAmmoReservation = false;
        public bool goldenArchery = false;
        public bool goldenEndurance = false;
        public bool goldenFeatherfall = false;
        public bool goldenFishing = false;
        public bool goldenInferno = false;
        public bool goldenNightOwl = false;

        public int goldenInfernoCounter = 0;

        public override void ResetEffects()
        {
            goldenAmmoReservation = false;
            goldenArchery = false;
            goldenEndurance = false;
            goldenFeatherfall = false;
            goldenFishing = false;
            goldenInferno = false;
            goldenNightOwl = false;
        }

        // -- Testers -- //

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            return !goldenAmmoReservation || Main.rand.NextFloat() > 0.4f;
        }

        // -- Getters -- //

        public override void GetFishingLevel(Item fishingRod, Item bait, ref float fishingLevel)
        {
            if (goldenFishing)
            {
                fishingLevel += 0.6f;
            }
        }

        // -- Modifiers -- //

        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (goldenArchery)
            {
                velocity *= 1.4f;
                damage = (int)(damage * 1.4f);
            }
        }

        // -- Post Updates -- //

        public override void PostUpdate()
        {
            goldenInfernoCounter++;
            if (goldenInfernoCounter >= 180)
            {
                goldenInfernoCounter = 0;
            }
        }

        // -- Pre Updates -- //

        public override void PreUpdateMovement()
        {
            if (goldenFeatherfall && !Player.controlDown && Player.velocity.Y > 0f)
            {
                Player.velocity.Y = Player.controlUp ? 0.0001f : (1f / 6f);
            }
        }
    }
}
