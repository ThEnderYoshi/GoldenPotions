using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Projectiles;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenLovePotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.LovePotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Throw this to make someone REALLY fall in love");
        }

        public override void PreDefaults()
        {
            Item.CloneDefaults(ItemID.LovePotion);
        }

        public override void SafeDefaults()
        {
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.shoot = ModContent.ProjectileType<GoldenLovePotionProj>();
        }
    }
}
