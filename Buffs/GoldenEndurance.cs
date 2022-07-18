using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenEndurance : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Endurance;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endurance++");
            Description.SetDefault("20% reduced damage");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.endurance += 0.2f;
        }
    }
}
