using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenBattlePotion : GoldenPotion
    {
        public override int NormalPotion => ItemID.BattlePotion;

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 32;

            Item.buffType = BuffID.Battle;
            Item.buffTime = 14 * 60 * 60;
        }
    }
}
