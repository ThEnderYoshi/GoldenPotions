using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenEndurancePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.EndurancePotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Reduces damage taken by 20%");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 40;

            Item.buffType = ModContent.BuffType<GoldenEndurance>();
            Item.buffTime = 14400; // 4 minutes
        }
    }
}
