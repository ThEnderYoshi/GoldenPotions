using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Projectiles;
using Microsoft.Xna.Framework;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenLovePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.LovePotion;

        public override void PreDefaults()
        {
            Item.CloneDefaults(ItemID.LovePotion);
        }

        public override void SafeDefaults()
        {
            Item.UseSound = SoundID.Item1;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.maxStack = 99;
            Item.shoot = ModContent.ProjectileType<GoldenLovePotionProj>();
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            // This is just to cancel out the drinking effect.
        }
    }
}
