﻿using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenEndurancePotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenEndurance : GoldenBuff
    {
        public override LocalizedText Description =>
            base.Description.WithFormatArgs(DamageReduction);

        public override int OverwriteBuff => BuffID.Endurance;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.endurance += DamageReduction * 0.01f;
        }
    }
}
