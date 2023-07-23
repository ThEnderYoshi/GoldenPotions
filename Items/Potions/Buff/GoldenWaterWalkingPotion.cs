using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWaterWalkingPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.WaterWalkingPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.WaterWalking;
            Item.buffTime = 20 * 60 * 60;
        }
    }
}
