using Terraria;
using Terraria.ID;
using Terraria.Localization;
using static GoldenPotions.Items.Potions.Buff.GoldenIronskinPotion;

namespace GoldenPotions.Buffs
{
    internal class GoldenIronskin : GoldenBuff
    {
        public override LocalizedText Description =>
            base.Description.WithFormatArgs(DefenseIncrease);

        public override int OverwriteBuff => BuffID.Ironskin;

        public override void Update(Player player, ref int buffIndex)
        {
            base.Update(player, ref buffIndex);
            player.statDefense += DefenseIncrease;
        }
    }
}
