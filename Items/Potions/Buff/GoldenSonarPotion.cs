using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSonarPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SonarPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Detects hooked fish");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 36;

            Item.buffType = BuffID.Sonar;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
