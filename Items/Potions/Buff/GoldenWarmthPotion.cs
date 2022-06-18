using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWarmthPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.WarmthPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Reduces damage from cold sources");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 30;

            Item.buffType = BuffID.Warmth;
            Item.buffTime = 108000; // 30 minutes
        }
    }
}
