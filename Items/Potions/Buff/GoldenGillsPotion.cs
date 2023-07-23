using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenGillsPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.GillsPotion;

        public override void SafeDefaults()
        {
            Item.width = 20;
            Item.height = 30;

            Item.buffType = BuffID.Gills;
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
