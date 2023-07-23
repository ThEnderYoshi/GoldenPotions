using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenAmmoReservationPotion : GoldenPotion
    {
        public const int NoConsumeChance = 40;

        public override int NormalPotion => ItemID.AmmoReservationPotion;
        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(NoConsumeChance);

        public override void SafeDefaults()
        {
            Item.width = 48;
            Item.height = 60;

            Item.buffType = ModContent.BuffType<GoldenAmmoReservation>();
            //Item.buffTime = 28800; // 8 minutes
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
