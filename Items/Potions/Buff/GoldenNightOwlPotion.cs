using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenNightOwlPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.NightOwlPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenNightOwl>();
            Item.buffTime = 3 * 60 * 60;
        }
    }
}
