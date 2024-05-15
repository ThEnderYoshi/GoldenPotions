using GoldenPotions.Players;
using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenNightOwl : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.NightOwl;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenNightOwl = true;
        }
    }
}
