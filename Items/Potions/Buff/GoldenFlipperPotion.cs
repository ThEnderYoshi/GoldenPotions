using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenFlipperPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.FlipperPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 36;

            Item.buffType = BuffID.Flipper;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
