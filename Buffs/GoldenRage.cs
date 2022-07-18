using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenRage : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Rage;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rage++");
            Description.SetDefault("20% increased critical chance");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetCritChance(DamageClass.Generic) += 20;
        }
    }
}
