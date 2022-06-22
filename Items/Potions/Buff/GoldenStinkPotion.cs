using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Projectiles;
using Microsoft.Xna.Framework;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenStinkPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.StinkPotion;

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Throw this to make someone smell incomprehensely horrible\nStacks with regular stinky");
        }

        public override void PreDefaults()
        {
            Item.CloneDefaults(ItemID.StinkPotion);
        }

        public override void SafeDefaults()
        {
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.maxStack = 99;
            Item.shoot = ModContent.ProjectileType<GoldenStinkPotionProj>();
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            // This is just to cancel out the drinking effect.
        }
    }
}
