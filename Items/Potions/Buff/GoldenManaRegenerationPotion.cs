using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenManaRegenerationPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.ManaRegenerationPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increased mana regeneration");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = BuffID.ManaRegeneration;
            Item.buffTime = 57600; // 16 minutes
        }
    }
}
