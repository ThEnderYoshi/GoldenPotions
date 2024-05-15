using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenShine : GoldenBuff
    {
        private const int LightDiamondRadius = 6; // In tiles.

        private static readonly Vector3 CenterLight = new(0.8f, 0.95f, 1f);
        private static readonly Vector3 CrossLight = new(1f, 0.9f, 0.7f);

        public override int OverwriteBuff => BuffID.Shine;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            Vector2 center = player.Center;

            for (var y = 1 - LightDiamondRadius; y <= LightDiamondRadius - 1; y++)
            {
                int rowLimit = LightDiamondRadius - 1 - Math.Abs(y);

                for (var x = -rowLimit; x <= rowLimit; x++)
                {
                    var offset = new Vector2(x * 16f, y * 16f);
                    bool inInnerLayer = Math.Abs(x) >= rowLimit - 1;
                    Lighting.AddLight(center + offset, inInnerLayer ? CenterLight : CrossLight);
                }
            }
        }
    }
}
