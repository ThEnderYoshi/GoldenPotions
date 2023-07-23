using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenManaRegenerationPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.ManaRegenerationPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.ManaRegeneration;
            Item.buffTime = 16 * 60 * 60;
        }
    }
}
