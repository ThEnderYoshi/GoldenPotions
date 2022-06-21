using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenTitan : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.Titan; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Titan++");
            Description.SetDefault("Greatly increased knockback");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetKnockback(DamageClass.Generic) *= 2f; // +100% knockback
        }
    }
}
