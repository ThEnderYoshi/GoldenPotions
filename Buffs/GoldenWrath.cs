using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using static GoldenPotions.Items.Potions.Buff.GoldenWrathPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenWrath : GoldenBuff
    {
        public override LocalizedText Description => base.Description.WithFormatArgs(PercentBoost);
        public override int OverwriteBuff => BuffID.Titan;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetDamage(DamageClass.Generic) *= 1f + PercentBoost * 0.01f;
        }
    }
}
