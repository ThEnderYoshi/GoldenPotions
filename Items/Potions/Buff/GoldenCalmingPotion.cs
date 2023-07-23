using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenCalmingPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.CalmingPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Calm;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
