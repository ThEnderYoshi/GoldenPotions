using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenMiningPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenMining : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(SpeedBoost);
        public override int OverwriteBuff => BuffID.Mining;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.pickSpeed -= SpeedBoost * 0.01f;
        }
    }
}
