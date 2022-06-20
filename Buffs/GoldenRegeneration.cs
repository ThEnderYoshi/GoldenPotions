using Terraria;
using Terraria.ID;

namespace GoldenPotions.Buffs
{
    internal class GoldenRegeneration : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.Regeneration; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Regeneration++");
            Description.SetDefault("Provides greater life regeneration");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.lifeRegen += 8;
        }
    }
}
