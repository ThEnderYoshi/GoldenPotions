using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Recovery
{
    internal class GoldenRestorationPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.RestorationPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Greatly reduced potion cooldown");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 26;
            Item.value = Item.sellPrice(silver: 6);

            Item.healLife = 100;
            Item.potion = true;
        }

        public override void OnConsumeItem(Player player)
        {
            // Force Potion Sickness to last 22.5 seconds
            player.ClearBuff(BuffID.PotionSickness);
            player.AddBuff(BuffID.PotionSickness, 1250); // 22.5 seconds
        }
    }
}
