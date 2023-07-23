using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSwiftnessPotion : GoldenPotion
    {
        public const int PercentBonus = 50;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(PercentBonus);
        public override int NormalPotion => ItemID.SwiftnessPotion;

        public override void SafeDefaults()
        {
            Item.width = 44;
            Item.height = 32;

            Item.buffType = ModContent.BuffType<GoldenSwiftness>();
            Item.buffTime = 8 * 20 * 20;
        }
    }
}
