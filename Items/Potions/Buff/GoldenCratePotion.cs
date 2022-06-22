using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenCratePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.CratePotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases chance to get a crate");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.Crate;
            Item.buffTime = 21600; // 6 minutes
        }
    }
}
