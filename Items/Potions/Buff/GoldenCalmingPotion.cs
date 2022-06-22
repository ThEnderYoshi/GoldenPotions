using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenCalmingPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.CalmingPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Decreases enemy spawn rate");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.Calm;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
