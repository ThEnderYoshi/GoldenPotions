using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenArcheryPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.ArcheryPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("40% increased arrow speed and damage");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.buffType = ModContent.BuffType<GoldenArchery>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
