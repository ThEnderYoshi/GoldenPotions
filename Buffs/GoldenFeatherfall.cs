using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenFeatherfall : GoldenBuff
    {
        public override int OverwriteBuff => BuffID.Featherfall;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Featherfall++");
            Description.SetDefault("Hold UP to stop gravity and DOWN to fall normally");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenPotionsPlayer>()
                    .goldenFeatherfall = true;
        }
    }
}
