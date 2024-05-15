using GoldenPotions.Players;
using Terraria;
using Terraria.ModLoader;

namespace GoldenPotions.GlobalEntities
{
    internal class GoldenPotionsGlobalWall : GlobalWall
    {
        public override void ModifyLight(
            int i,
            int j,
            int type,
            ref float r,
            ref float g,
            ref float b)
        {
            // Based on HERO's Mod's Light Hack service.
            // Pretty hacky; there's gotta be a better way to do fullbright...
            // (then again, it IS called 'Light HACK')
            //TODO: Check how Night Owl++ behaves in multiplayer
            Player player = Main.player[Main.myPlayer];

            if (player.GetModPlayer<GoldenPotionsPlayer>().GoldenNightOwl)
            {
                r = 1;
                g = 1;
                b = 1;
            }
        }
    }
}
