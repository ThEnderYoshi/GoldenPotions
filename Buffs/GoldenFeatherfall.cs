using GoldenPotions.Players;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenFeatherfall : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Featherfall;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenFeatherfall = true;
        }
    }
}
