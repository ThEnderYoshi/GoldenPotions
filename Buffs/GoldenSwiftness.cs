using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenSwiftnessPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenSwiftness : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(PercentBonus);
        public override int OverwriteBuff => BuffID.Swiftness;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.moveSpeed += PercentBonus * 0.01f;
        }
    }
}
