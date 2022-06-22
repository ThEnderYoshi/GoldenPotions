using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenFishingPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.FishingPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Greatly increases fishing power");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenFishing>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
