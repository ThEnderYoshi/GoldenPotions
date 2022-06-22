using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenIronskin : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Ironskin;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ironskin++");
            Description.SetDefault("Increase defense by 16");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.statDefense += 16;
        }
    }
}
