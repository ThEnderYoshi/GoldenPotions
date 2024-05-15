using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static GoldenPotions.Items.Potions.Buff.GoldenMagicPowerPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenMagicPower : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(PercentBonus);
        public override int OverwriteBuff => BuffID.MagicPower;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetDamage(DamageClass.Magic) *= 1.0f + PercentBonus * 0.01f;
        }
    }
}
