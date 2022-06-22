using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenMiningPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.MiningPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases mining speed by 50%");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenMining>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
