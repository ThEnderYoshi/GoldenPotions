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

        public override void Update(NPC npc, ref int buffIndex)
        {
            if (OverwriteBuff != -1 && npc.HasBuff(OverwriteBuff))
            {
                npc.DelBuff(buffIndex);
            }

            SafeUpdate(npc, ref buffIndex);
        }

        /// <summary>
        /// Use instead of <see cref="Update(Player, ref int)"/>.
        /// </summary>
        public virtual void SafeUpdate(Player player, ref int buffIndex) { }

        /// <summary>
        /// Use instead of <see cref="Update(NPC, ref int)"/>.
        /// </summary>
        public virtual void SafeUpdate(NPC npc, ref int buffIndex) { }
    }
}
