using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenShine : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Shine;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shine++");
            Description.SetDefault("Emitting a lot of light");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            const int offset = 3; // In tiles
            Vector2 pos = new Vector2(player.position.X / 16, player.position.Y / 16);

            // "+" shape with 5 points of light
            Lighting.AddLight((int)pos.X, (int)pos.Y,         0.8f, 0.95f, 1f);
            Lighting.AddLight((int)pos.X, (int)pos.Y - offset, 1f, 0.9f, 0.7f);
            Lighting.AddLight((int)pos.X - offset, (int)pos.Y, 1f, 0.9f, 0.7f);
            Lighting.AddLight((int)pos.X, (int)pos.Y + offset, 1f, 0.9f, 0.7f);
            Lighting.AddLight((int)pos.X + offset, (int)pos.Y, 1f, 0.9f, 0.7f);
        }
    }
}
