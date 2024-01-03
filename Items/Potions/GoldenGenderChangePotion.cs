using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions
{
    internal class GoldenGenderChangePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.GenderChangePotion;

        public override void SafeDefaults()
        {
            Item.width = 32;
            Item.height = 38;
            Item.UseSound = SoundID.Item6;
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            if (player.ItemTimeIsZero)
            {
                player.ApplyItemTime(Item);
                return;
            }

            float t = (float)(Item.useTime - player.itemTime) / Item.useTime;
            float threePi = 3f * (float)Math.PI;
            var pointInCircle = new Vector2(15f, 0f).RotatedBy(threePi * t);
            pointInCircle.X *= player.direction;

            SpawnGenderDust(player, DustID.FireworkFountain_Blue, pointInCircle.X, t);
            SpawnGenderDust(player, DustID.FireworkFountain_Red, -pointInCircle.X, t);
        }

        private void SpawnGenderDust(Player player, int dustType, float x, float t)
        {
            const float offset = 44f;
            Vector2 dustPosition = new Vector2(x, offset * (1f - t) - offset + player.height * 0.5f)
                + player.Center;

            Dust dust = Main.dust[Dust.NewDust(dustPosition, 0, 0, dustType, 0f, 0f, 100)];
            dust.position = dustPosition;
            dust.noGravity = true;
            dust.velocity = Vector2.Zero;
            dust.scale = 1.3f;
            dust.customData = this;
        }
    }
}
