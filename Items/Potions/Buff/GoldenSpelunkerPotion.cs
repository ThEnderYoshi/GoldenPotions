using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenSpelunkerPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.SpelunkerPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 30;

            Item.buffType = BuffID.Spelunker;
            Item.buffTime = 10 * 60 * 60;
        }
    }
}
