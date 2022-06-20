using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenInfernoPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.InfernoPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Ignites nearby enemies with hellfire");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 40;

            Item.buffType = ModContent.BuffType<GoldenInferno>();
            Item.buffTime = 14400; // 4 minutes
        }
    }
}
