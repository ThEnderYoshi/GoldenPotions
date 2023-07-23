using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenGravitationPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.GravitationPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Gravitation;
            Item.buffTime = 6 * 60 * 60;
        }
    }
}
