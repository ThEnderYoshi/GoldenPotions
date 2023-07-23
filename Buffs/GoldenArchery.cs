using GoldenPotions.Items.Potions.Buff;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace GoldenPotions.Buffs
{
    internal class GoldenArchery : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(GoldenArcheryPotion.SpeedAndDamageBonus);
        public override int OverwriteBuff => BuffID.Archery;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenArchery = true;
        }
    }
}
