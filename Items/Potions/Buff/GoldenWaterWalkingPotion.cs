using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWaterWalkingPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.WaterWalkingPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Allows the ability to walk on water");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.WaterWalking;
            Item.buffTime = 72000; // 20 minutes
        }
    }
}
