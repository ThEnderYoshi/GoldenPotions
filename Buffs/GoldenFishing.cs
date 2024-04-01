using GoldenPotions.Players;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenFishing : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Fishing;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenFishing = true;
        }
    }
}
