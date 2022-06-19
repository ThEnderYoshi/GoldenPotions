using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenNightOwl : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.NightOwl; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Night Owl++");
            Description.SetDefault("MY EYES");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            // See GoldenPotionsPlayer; GoldenNightOwlGlobalWall
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenNightOwl = true;
        }
    }

    internal class GoldenNightOwlGlobalWall : GlobalWall
    {
        public override void ModifyLight(int i, int j, int type, ref float r, ref float g, ref float b)
        {
            // Based on HERO's Mod's Light Hack service.
            // Pretty hacky; there's gotta be a better way to do fullbright...
            // (then again, it IS called 'Light HACK')
            //TODO: Check how Night Owl++ behaves in multiplayer
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if (k == Main.myPlayer && player.GetModPlayer<GoldenPotionsPlayer>().goldenNightOwl)
                {
                    r = 1;
                    g = 1;
                    b = 1;
                    break;
                }
            }
        }
    }
}
