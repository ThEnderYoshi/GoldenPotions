using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenSummoning : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Summoning;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoning++");
            Description.SetDefault("Increased max number of minions");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.maxMinions += 2;
        }
    }
}
