using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenLifeforcePotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenLifeforce : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(PercentBonus);
        public override int OverwriteBuff => BuffID.Lifeforce;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            // What the fuck is happening here.
            // What are these numbers.
            player.statLifeMax2 += player.statLifeMax / 5 / 20 * 20 * 2;
        }
    }
}
