using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenAmmoReservationPotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.AmmoReservationPotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("40% chance not to consume ammo");
        }

        public override void SafeDefaults()
        {
            Item.width = 48;
            Item.height = 60;

            Item.buffType = ModContent.BuffType<GoldenAmmoReservation>();
            Item.buffTime = 28800; // 8 minutes
        }
    }
}
