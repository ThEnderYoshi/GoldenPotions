using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenRagePotion : GoldenPotion
    {
        public const int PercentBonus = 20;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(PercentBonus);
        public override int NormalPotion => ItemID.RagePotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenRage>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
