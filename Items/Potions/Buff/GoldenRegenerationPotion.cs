using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenRegenerationPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.RegenerationPotion;

        public override void SafeDefaults()
        {
            Item.width = 12;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenRegeneration>();
            Item.buffTime = 8 * 60 * 60;
        }
    }
}
