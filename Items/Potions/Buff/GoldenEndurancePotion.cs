using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenEndurancePotion : GoldenPotion
    {
        public const int DamageReduction = 20;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(DamageReduction);
        public override int NormalPotion => ItemID.EndurancePotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 40;

            Item.buffType = ModContent.BuffType<GoldenEndurance>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
