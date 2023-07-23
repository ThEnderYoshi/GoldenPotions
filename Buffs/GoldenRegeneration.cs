using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenRegeneration : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Regeneration;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.lifeRegen += 8;
        }
    }
}
