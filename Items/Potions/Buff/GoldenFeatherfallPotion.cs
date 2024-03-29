﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Buffs;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenFeatherfallPotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.FeatherfallPotion;

        public override void SafeDefaults()
        {
            Item.width = 28;
            Item.height = 30;

            Item.buffType = ModContent.BuffType<GoldenFeatherfall>();
            Item.buffTime = 4 * 60 * 60;
        }
    }
}
