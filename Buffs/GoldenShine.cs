using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenShine : GoldenBuff
    {
        private static readonly Vector3 CenterLight = new(0.8f, 0.95f, 1f);
        private static readonly Vector3 CrossLight = new(1f, 0.9f, 0.7f);

        public override int OverwriteBuff => BuffID.Shine;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            const int offset = 3 * 16;
            var position = new Vector2(player.Center.X, player.Center.Y);
            Lighting.AddLight(position, CenterLight);
            Lighting.AddLight(position - Vector2.UnitY * offset, CrossLight);
            Lighting.AddLight(position - Vector2.UnitX * offset, CrossLight);
            Lighting.AddLight(position + Vector2.UnitY * offset, CrossLight);
            Lighting.AddLight(position + Vector2.UnitX * offset, CrossLight);
        }
    }
}
