using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenGravitationPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.GravitationPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Allows the control of gravity");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Gravitation;
            Item.buffTime = 21600; // 6 minutes
        }
    }
}
