using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Recovery
{
    internal class GoldenHealingPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SuperHealingPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("'This was a mistake'");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 34;
            Item.value = Item.sellPrice(silver: 60);

            Item.healLife = 350;
            Item.potion = true;
        }
    }
}
