using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;

namespace GoldenPotions.Buffs
{
    internal class GoldenLove : GoldenBuff
    {

        public override int OverwriteBuff
        {
            get { return BuffID.Lovestruck; }
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lovestruck++");
            Description.SetDefault("You are absolutely and completely consumed by love!");
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            SpawnHeart(player.GetSource_Buff(buffIndex), player.position, player.Size);
        }

        public override void SafeUpdate(NPC npc, ref int buffIndex)
        {
            SpawnHeart(npc.GetSource_Buff(buffIndex), npc.position, npc.Size);
        }

        private void SpawnHeart(IEntitySource source, Vector2 topLeft, Vector2 size)
        {
            // 331 == Lovestruck/Rapid Healing gore ID (not listed in GoreID)
            Vector2 pos = Main.rand.NextVector2FromRectangle(new Rectangle(0, -4, (int)size.X, (int)size.Y));
            int gore = Gore.NewGore(source, topLeft + pos, Vector2.Zero, 331);
            Main.gore[gore].velocity *= 0.3f;
        }
    }
}
