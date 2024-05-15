using GoldenPotions.Items.Potions.Buff;
using GoldenPotions.Players;
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

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenAmmoReservation = true;
        }
    }
}
