using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenFeatherfall : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Featherfall;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>().goldenFeatherfall = true;
        }
    }
}
