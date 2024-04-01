using GoldenPotions.Players;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenNightOwl : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.NightOwl;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenNightOwl = true;
        }
    }

    //TODO: (maybe?) Move `GoldenNightOwlGlobalWall` to own file.
    internal class GoldenNightOwlGlobalWall : GlobalWall
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
