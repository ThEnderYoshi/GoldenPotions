using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Recovery
{
    internal class GoldenManaPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SuperManaPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 38;
            Item.value = Item.sellPrice(silver: 6);

            Item.healMana = 450;
        }
    }
}
