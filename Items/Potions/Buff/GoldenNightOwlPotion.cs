using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenNightOwlPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.NightOwlPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Grants full night vision\n'Warning: Will make your map ugly as sin'");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenNightOwl>();
            Item.buffTime = 10800; // 3 minutes
        }
    }
}
