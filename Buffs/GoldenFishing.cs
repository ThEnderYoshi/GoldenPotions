using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenFishing : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Fishing;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fishing++");
            Description.SetDefault("Greatly increased fishing power");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenFishing = true;
        }
    }
}
