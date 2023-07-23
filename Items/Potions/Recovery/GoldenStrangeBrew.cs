using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Recovery
{
    internal class GoldenStrangeBrew : GoldenPotion
    {
        public override int NormalPotion => ItemID.StrangeBrew;

        public override void SafeDefaults()
        {
            Item.width = 26;
            Item.height = 34;
            Item.value = Item.sellPrice(silver: 2);

            Item.healMana = 600;
            Item.healLife = 160;
            Item.potion = true;
        }
    }
}
