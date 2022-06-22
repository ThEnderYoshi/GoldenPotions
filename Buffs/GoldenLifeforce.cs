using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenLifeforce : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Lifeforce;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lifeforce++");
            Description.SetDefault("40% increased max life");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20 * 2;
            // Why are there 2 max lives?
        }
    }
}
