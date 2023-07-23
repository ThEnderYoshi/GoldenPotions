using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSonarPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SonarPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 36;

            Item.buffType = BuffID.Sonar;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
