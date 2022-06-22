using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSwiftnessPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SwiftnessPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("50% increased movement speed");
        }

        public override void SafeDefaults()
        {
            Item.width = 44;
            Item.height = 32;

            Item.buffType = ModContent.BuffType<GoldenSwiftness>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
