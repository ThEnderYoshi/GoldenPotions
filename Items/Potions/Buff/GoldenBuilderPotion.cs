using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenBuilderPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.BuilderPotion;

        public override void SafeDefaults()
        {
            Item.width = 40;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenBuilder>();
            Item.buffTime = 45 * 60 * 60;
        }
    }
}
