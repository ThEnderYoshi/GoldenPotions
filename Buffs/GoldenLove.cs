using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;

namespace GoldenPotions.Buffs
{
    internal class GoldenLove : GoldenBuff
    {
        // Not in GoreID for some reason.
        public const int HeartGore = 331;

        public override int OverwriteBuff => BuffID.Lovestruck;

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            SpawnHeart(player.GetSource_Buff(buffIndex), player.position, player.Size);
        }

        public override void SafeUpdate(NPC npc, ref int buffIndex)
        {
            SpawnHeart(npc.GetSource_Buff(buffIndex), npc.position, npc.Size);
        }

        private static void SpawnHeart(IEntitySource source, Vector2 topLeft, Vector2 size)
        {
            Vector2 pos = Main.rand.NextVector2FromRectangle(new Rectangle(-8, -4, (int)size.X, (int)size.Y));
            int gore = Gore.NewGore(source, topLeft + pos, Vector2.Zero, HeartGore);
            Main.gore[gore].velocity *= 0.3f;
        }
    }
}
