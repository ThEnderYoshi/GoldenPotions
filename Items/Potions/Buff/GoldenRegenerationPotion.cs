using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenRegenerationPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.RegenerationPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Provides greater life regeneration");
        }

        public override void SafeDefaults()
        {
            Item.width = 12;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenRegeneration>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
