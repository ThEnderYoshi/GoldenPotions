using Terraria;
using Terraria.ID;

namespace GoldenPotions.Items.Potions.Buff
{
    internal class GoldenBattlePotion : GoldenPotion
    {
        public override int NormalPotion
        {
            get { return ItemID.BattlePotion; }
        }

        public override void SafeStaticDefaults()
        {
            Tooltip.SetDefault("Increases enemy spawn rate");
        }

        public override void SafeDefaults()
        {
            Item.width = 36;
            Item.height = 32;

            Item.buffType = BuffID.Battle;
            Item.buffTime = 50400; // 14 minutes
        }
    }
}
