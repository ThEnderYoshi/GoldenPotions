using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenDangersensePotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.TrapsightPotion; } // TrapSight is Dangersense
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Allows you to see nearby danger sources");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Dangersense;
            Item.buffTime = 72000; // 20 minutes
        }
    }
}
