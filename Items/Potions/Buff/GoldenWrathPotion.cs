using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWrathPotion : GoldenPotion
    {
        public const int PercentBoost = 20;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(PercentBoost);
        public override int NormalPotion => ItemID.WrathPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 38;

            Item.buffType = ModContent.BuffType<GoldenWrath>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
