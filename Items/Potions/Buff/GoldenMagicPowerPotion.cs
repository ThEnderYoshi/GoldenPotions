using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenMagicPowerPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.MagicPowerPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("40% increased magic damage");
        }

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenMagicPower>();
            Item.buffTime = 14400; // 4 minutes
        }
    }
}
