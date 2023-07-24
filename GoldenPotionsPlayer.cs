using GoldenPotions.Items.Potions.Buff;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
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

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            return !goldenAmmoReservation
                || (Main.rand.NextFloat() > GoldenAmmoReservationPotion.NoConsumeChance * 0.01f);
        }

        public override void GetFishingLevel(Item fishingRod, Item bait, ref float fishingLevel)
        {
            if (goldenFishing)
            {
                fishingLevel += 0.6f;
            }
        }

        public override void ModifyShootStats(
            Item item,
            ref Vector2 position,
            ref Vector2 velocity,
            ref int type,
            ref int damage,
            ref float knockback
        )
        {
            if (goldenArchery && item.useAmmo == AmmoID.Arrow)
            {
                float multiplier = 1.0f + GoldenArcheryPotion.SpeedAndDamageBonus * 0.1f;
                velocity *= multiplier;
                damage = (int)(damage * multiplier);
            }
        }

        public override void PreUpdateMovement()
        {
            if (goldenFeatherfall && !Player.controlDown && Player.velocity.Y > 0f)
            {
                const float regularFallSpeed = 1f / 6f;
                const float hoverFallSpeed = 0.0001f;
                Player.velocity.Y = Player.controlUp ? hoverFallSpeed : regularFallSpeed;
            }
        }

        public override void PostUpdate()
        {
            goldenInfernoCounter++;
            if (goldenInfernoCounter >= 180)
            {
                goldenInfernoCounter = 0;
            }
        }
    }
}
