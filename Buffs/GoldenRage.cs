using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static GoldenPotions.Items.Potions.Buff.GoldenRagePotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenRage : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(PercentBonus);
        public override int OverwriteBuff => BuffID.Rage;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetCritChance(DamageClass.Generic) += PercentBonus;
        }
    }
}
