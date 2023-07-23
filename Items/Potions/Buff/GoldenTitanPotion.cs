using GoldenPotions.Buffs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenTitanPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.TitanPotion;

        public override void SafeDefaults()
        {
            Item.width = 44;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenTitan>();
            Item.buffTime = 8 * 20 * 20;
        }
    }
}
