using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenBuilder : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.Builder; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Builder++");
            Description.SetDefault("Increased placement speed and range");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.tileSpeed *= 1.5f;
            player.wallSpeed *= 1.5f;
        }
    }
}
