using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenThornsPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.ThornsPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Attackers also take damage");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.buffType = BuffID.Thorns;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
