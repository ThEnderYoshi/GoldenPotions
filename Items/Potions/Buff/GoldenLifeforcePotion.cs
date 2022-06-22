using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenLifeforcePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.LifeforcePotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases max life by 40%");
        }

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 34;

            Item.buffType = ModContent.BuffType<GoldenLifeforce>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
