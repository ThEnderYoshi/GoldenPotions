using Terraria;
using Terraria.ModLoader;

namespace GoldenPotions.Buffs
{
    public abstract class GoldenBuff : ModBuff
    {
        /// <summary>
        /// <para>The "downgraded" version of this buff.</para>
        /// <para>Set to -1 if it doesn't have one.</para>
        /// </summary>
        public abstract int OverwriteBuff { get; }

        public override void Update(Player player, ref int buffIndex)
        {
            if (OverwriteBuff != -1 && player.HasBuff(OverwriteBuff))
            {
                player.ClearBuff(OverwriteBuff);
            }
            SafeUpdate(player, ref buffIndex);
        }

        /// <summary>
        /// Use instead of <see cref="Update"/>.
        /// </summary>
        public virtual void SafeUpdate(Player player, ref int buffIndex) {}
    }
}
