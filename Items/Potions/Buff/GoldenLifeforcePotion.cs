using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenLifeforcePotion : GoldenPotion
    {
        public const int PercentBonus = 40;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(PercentBonus);
        public override int NormalPotion => ItemID.LifeforcePotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenLifeforce>();
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
