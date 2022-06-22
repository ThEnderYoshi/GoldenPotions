using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenArchery : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Archery;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Archery++");
            Description.SetDefault("40% increased arrow speed and damage");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenArchery = true;
        }
    }
}
