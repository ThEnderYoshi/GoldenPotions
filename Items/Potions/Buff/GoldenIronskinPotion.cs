using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenIronskinPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.IronskinPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increase defense by 16");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenIronskin>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
