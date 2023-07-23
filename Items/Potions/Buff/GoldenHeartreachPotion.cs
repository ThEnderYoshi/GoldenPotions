using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenHeartreachPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.HeartreachPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = BuffID.Heartreach;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
