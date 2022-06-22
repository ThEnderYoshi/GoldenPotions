using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenHunterPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.HunterPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Shows the location of enemies");
        }

        public override void SafeDefaults()
        {
            Item.width = 40;
            Item.height = 30;

            Item.buffType = BuffID.Hunter;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
