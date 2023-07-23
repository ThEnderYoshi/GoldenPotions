using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenMagicPowerPotion : GoldenPotion
    {
        public const int PercentBonus = 40;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(PercentBonus);
        public override int NormalPotion => ItemID.MagicPowerPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenMagicPower>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
