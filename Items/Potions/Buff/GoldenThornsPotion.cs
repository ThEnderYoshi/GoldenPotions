using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenThornsPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.ThornsPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.buffType = BuffID.Thorns;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
