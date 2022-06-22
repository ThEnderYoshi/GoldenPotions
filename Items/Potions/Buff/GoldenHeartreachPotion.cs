using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenHeartreachPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.HeartreachPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases pickup range for life hearts");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.Heartreach;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
