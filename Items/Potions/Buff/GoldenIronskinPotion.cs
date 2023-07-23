using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenIronskinPotion : GoldenPotion
    {
        public const int DefenseIncrease = 16;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(DefenseIncrease);
        public override int NormalPotion => ItemID.IronskinPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenIronskin>();
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
