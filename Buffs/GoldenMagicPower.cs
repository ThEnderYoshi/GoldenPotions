using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    internal class GoldenMagicPower : GoldenBuff
    {
        public override int OverwriteBuff
        {
            get { return BuffID.MagicPower; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Power++");
            Description.SetDefault("40% increased magic damage");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetDamage(DamageClass.Magic) *= 1.4f;
        }
    }
}
