using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenInvisibilityPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.InvisibilityPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Invisibility;
            Item.buffTime = 6 * 60 * 60;
        }
    }
}
