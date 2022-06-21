using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenWrathPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.WrathPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases damage by 20%");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 38;

            Item.buffType = ModContent.BuffType<GoldenWrath>();
            Item.buffTime = 14400; // 4 minutes
        }
    }
}
