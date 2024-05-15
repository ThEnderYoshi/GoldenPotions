using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenTitan : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Titan;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetKnockback(DamageClass.Generic) *= 2f;
        }
    }
}
