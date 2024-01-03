using GoldenPotions.Items.Potions.Buff;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace GoldenPotions.Buffs
{
    internal class GoldenAmmoReservation : GoldenBuff
    {
        public override LocalizedText Description =>
            base.Description.WithFormatArgs(GoldenAmmoReservationPotion.NoConsumeChance);

        public override int OverwriteBuff => BuffID.AmmoReservation;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>().goldenAmmoReservation = true;
        }
    }
}
