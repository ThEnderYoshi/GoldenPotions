using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSummoningPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.SummoningPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases your max number of minions by 2");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenSummoning>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
