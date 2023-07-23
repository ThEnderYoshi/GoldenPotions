using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenMiningPotion : GoldenPotion
    {
        public const int SpeedBoost = 50;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(SpeedBoost);
        public override int NormalPotion => ItemID.MiningPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenMining>();
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
