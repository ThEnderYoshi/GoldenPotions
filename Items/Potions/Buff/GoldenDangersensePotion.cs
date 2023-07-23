using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenDangersensePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.TrapsightPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Dangersense;
            Item.buffTime = 20 * 60 * 60;
        }
    }
}
