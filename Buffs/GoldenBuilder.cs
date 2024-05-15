using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenBuilder : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Builder;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.tileSpeed *= 1.5f;
            player.wallSpeed *= 1.5f;
            player.blockRange += 2;
        }
    }
}
