﻿using GoldenPotions.Items.Potions.Buff;
using GoldenPotions.Players;
using Terraria;
using Terraria.ID;
using Terraria.Localization;

namespace GoldenPotions.Buffs
{
    internal class GoldenArchery : GoldenBuff
    {
        public override LocalizedText Description =>
            base.Description.WithFormatArgs(GoldenArcheryPotion.SpeedAndDamageBonus);

        public override int OverwriteBuff => BuffID.Archery;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.GetModPlayer<GoldenPotionsPlayer>().GoldenArchery = true;
        }
    }
}
