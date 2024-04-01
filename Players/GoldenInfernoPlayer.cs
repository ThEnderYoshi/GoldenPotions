using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace GoldenPotions.Players
{
    internal class GoldenInfernoPlayer : ModPlayer
    {
        private const string RingTexturePath = $"{nameof(GoldenPotions)}/Buffs/GoldenInferno_Ring";
        const float SingleRingScaleFactor = 0.1f;
        const float ColorOffset = 0.9f;

        private static readonly Vector2 _ringDrawOrigin = new(200f);
        private static Asset<Texture2D> _ringTexture;

        private float _overallRingRotation;
        private float _overallRingScale = 1f;

        public override void SetStaticDefaults()
        {
            _ringTexture = ModContent.Request<Texture2D>(RingTexturePath);
        }

        public override void DrawEffects(
            PlayerDrawSet drawInfo,
            ref float r,
            ref float g,
            ref float b,
            ref float a,
            ref bool fullBright)
        {
            if (!Player.GetModPlayer<GoldenPotionsPlayer>().GoldenInferno || drawInfo.shadow != 0f)
                return;

            DrawRing();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void DrawRing()
        {
            if (!Main.gamePaused)
            {
                _overallRingRotation += 0.05f;
                _overallRingScale += 0.004f;
            }

            _overallRingRotation = MathHelper.WrapAngle(_overallRingRotation);

            if (_overallRingScale >= 1f)
            {
                _overallRingScale = 0.8f;
            }

            for (var i = 0; i < 3; i++)
            {
                Vector2 position = Player.Center;
                position.Y += Player.gfxOffY;

                float scale = _overallRingScale + SingleRingScaleFactor * i;

                if (scale > 1f)
                    scale -= SingleRingScaleFactor * 2f;

                float colorChannel =
                    MathHelper.Lerp(0.8f, 0f, Math.Abs(scale - ColorOffset) * 10f);

                var color =
                    new Color(colorChannel, colorChannel, colorChannel, colorChannel * 0.5f);

                Main.spriteBatch.Draw(
                    _ringTexture.Value,
                    position - Main.screenPosition,
                    new Rectangle(0, 400 * i, 400, 400),
                    color,
                    _overallRingRotation + MathHelper.Pi / 3f * i,
                    _ringDrawOrigin,
                    scale,
                    SpriteEffects.None,
                    layerDepth: 0f);
            }
        }
    }
}
