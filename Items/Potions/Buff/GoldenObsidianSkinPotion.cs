using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenObsidianSkinPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.ObsidianSkinPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Provides immunity to lava");
        }

        public override void SafeDefaults()
        {
            Item.width = 30;
            Item.height = 34;

            Item.buffType = BuffID.ObsidianSkin;
            Item.buffTime = 43200; // 12 minutes
        }
    }
}
