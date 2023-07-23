using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenSummoningPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenSummoning : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(SlotBonus);
        public override int OverwriteBuff => BuffID.Summoning;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.maxMinions += SlotBonus;
        }
    }
}
