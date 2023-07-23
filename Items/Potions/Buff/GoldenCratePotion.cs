using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenCratePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.CratePotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.Crate;
            Item.buffTime = 6 * 60 * 60;
        }
    }
}
