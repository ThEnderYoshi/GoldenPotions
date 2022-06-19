using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenMining : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.Mining; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mining++");
            Description.SetDefault("50% increased mining speed");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.pickSpeed -= 0.5f;
        }
    }
}
