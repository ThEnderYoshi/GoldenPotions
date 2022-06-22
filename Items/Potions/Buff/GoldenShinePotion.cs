using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenShinePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.ShinePotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Emits an aura of bright light");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 32;

            Item.buffType = ModContent.BuffType<GoldenShine>();
            Item.buffTime = 36000; // 10 minutes
        }
    }
}
