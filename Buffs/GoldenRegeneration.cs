using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenRegeneration : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Regeneration;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.lifeRegen += 8;
        }
    }
}
