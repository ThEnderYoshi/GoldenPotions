using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenWrath : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Titan;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Wrath++");
            Description.SetDefault("20% increased damage");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Generic) *= 1.2f;
        }
    }
}
