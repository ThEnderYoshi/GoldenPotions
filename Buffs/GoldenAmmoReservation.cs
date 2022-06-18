using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenAmmoReservation : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.AmmoReservation; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ammo Reservation++");
            Description.SetDefault("40% chance to not consume ammo");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenAmmoReservation = true;
        }
    }
}
