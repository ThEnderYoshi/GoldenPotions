using GoldenPotions.Items.Potions.Buff;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Players
{
    internal class GoldenPotionsPlayer : ModPlayer
    {
        public bool GoldenAmmoReservation = false;
        public bool GoldenArchery = false;
        public bool GoldenEndurance = false;
        public bool GoldenFeatherfall = false;
        public bool GoldenFishing = false;
        public bool GoldenInferno = false;
        public bool GoldenNightOwl = false;

        public int GoldenInfernoCounter = 0;

        public override void ResetEffects()
        {
            GoldenAmmoReservation = false;
            GoldenArchery = false;
            GoldenEndurance = false;
            GoldenFeatherfall = false;
            GoldenFishing = false;
            GoldenInferno = false;
            GoldenNightOwl = false;
        }

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            return !GoldenAmmoReservation
                || Main.rand.NextFloat() > GoldenAmmoReservationPotion.NoConsumeChance * 0.01f;
        }

        public override void GetFishingLevel(Item fishingRod, Item bait, ref float fishingLevel)
        {
            if (GoldenFishing)
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
            if (GoldenArchery && item.useAmmo == AmmoID.Arrow)
            {
                float multiplier = 1.0f + GoldenArcheryPotion.SpeedAndDamageBonus * 0.1f;
                velocity *= multiplier;
                damage = (int)(damage * multiplier);
            }
        }

        public override void PreUpdateMovement()
        {
            if (GoldenFeatherfall && !Player.controlDown && Player.velocity.Y > 0f)
            {
                const float regularFallSpeed = 1f / 6f;
                const float hoverFallSpeed = 0.0001f;
                Player.velocity.Y = Player.controlUp ? hoverFallSpeed : regularFallSpeed;
            }
        }

        public override void PostUpdate()
        {
            GoldenInfernoCounter++;
            if (GoldenInfernoCounter >= 180)
            {
                GoldenInfernoCounter = 0;
            }
        }
    }
}
