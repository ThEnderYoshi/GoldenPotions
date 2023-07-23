using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSummoningPotion : GoldenPotion
    {
        public const int SlotBonus = 2;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(SlotBonus);
        public override int NormalPotion => ItemID.SummoningPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenSummoning>();
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
