using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenLuckPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.LuckPotionGreater;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases the Luck of the user");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;
            Item.value = Item.sellPrice(gold: 2);

            Item.buffType = BuffID.Lucky;
            Item.buffTime = 72000; // 20 minutes
        }
    }
}
