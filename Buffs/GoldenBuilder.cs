using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenBuilder : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Builder;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Builder++");
            Description.SetDefault("Greatly increased placement speed and range");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.tileSpeed *= 1.5f;
            player.wallSpeed *= 1.5f;
            player.blockRange += 2;
        }
    }
}
