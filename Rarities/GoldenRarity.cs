using Microsoft.Xna.Framework;
using Terraria.ModLoader;

namespace GoldenPotions.Rarities
{
    internal class GoldenRarity : ModRarity
    {
        public override Color RarityColor => new Color(255, 249, 181);

        public override int GetPrefixedRarity(int offset, float valueMult)
        {
            return Type;
        }
    }
}
