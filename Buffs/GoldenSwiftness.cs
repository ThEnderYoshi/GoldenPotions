using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenSwiftness : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Swiftness;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Swiftness++");
            Description.SetDefault("50% increased movement speed");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.moveSpeed += 0.5f;
        }
    }
}
