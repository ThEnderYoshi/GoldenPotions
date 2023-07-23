using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWarmthPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.WarmthPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 30;

            Item.buffType = BuffID.Warmth;
            Item.buffTime = 30 * 60 * 60;
        }
    }
}
