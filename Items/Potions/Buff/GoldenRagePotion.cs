using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenRagePotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.RagePotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases critical chance by 20%");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenRage>();
            Item.buffTime = 14400; // 4 minutes
        }
    }
}
