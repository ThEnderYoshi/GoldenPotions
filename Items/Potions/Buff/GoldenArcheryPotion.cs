using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;
using Terraria.Localization;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenArcheryPotion : GoldenPotion
    {
        public const int SpeedAndDamageBonus = 40;

        public override LocalizedText Tooltip => base.Tooltip.WithFormatArgs(SpeedAndDamageBonus);
        public override int NormalPotion => ItemID.ArcheryPotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.buffType = ModContent.BuffType<GoldenArchery>();
            Item.buffTime = 8 * 60 * 60; // 8 minutes
        }
    }
}
