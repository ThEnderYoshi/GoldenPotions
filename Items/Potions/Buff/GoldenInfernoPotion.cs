using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenInfernoPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.InfernoPotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 40;

            Item.buffType = ModContent.BuffType<GoldenInferno>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
