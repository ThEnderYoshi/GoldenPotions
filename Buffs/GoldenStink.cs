using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace GoldenPotions.Buffs
{
    internal class GoldenStink : GoldenBuff
    {

        public override int OverwriteBuff => -1;

        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = true;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
        }

        public override void SafeUpdate(Player player, ref int buffIndex)
        {
            player.GetModPlayer<GoldenStinkPlayer>().goldenStink = true;
            SpawnFarts(player.GetSource_Buff(buffIndex), player.position, player.Size);
        }

        public override void SafeUpdate(NPC npc, ref int buffIndex)
        {
            SpawnFarts(npc.GetSource_Buff(buffIndex), npc.position, npc.Size);
        }

        // SpawnHearts more like SpawnFARTS gottem
        private static void SpawnFarts(IEntitySource source, Vector2 topLeft, Vector2 size)
        {
            if (Main.rand.NextBool(4)) { return; }

            var rect = new Rectangle(-16, -4, (int)size.X, (int)size.Y);
            Vector2 pos = Main.rand.NextVector2FromRectangle(rect);

            int gore =
                Gore.NewGore(source, topLeft + pos, Vector2.Zero, Main.rand.Next(436, 438), 0.5f);

            Main.gore[gore].velocity *= 0.3f;
            Main.gore[gore].alpha = 127;
        }
    }

    internal class GoldenStinkPlayer : ModPlayer
    {
        public bool goldenStink = false;

        public override void ResetEffects()
        {
            goldenStink = false;
        }

        public override void DrawEffects(
            PlayerDrawSet drawInfo,
            ref float r,
            ref float g,
            ref float b,
            ref float a,
            ref bool fullBright)
        {
            if (goldenStink)
            {
                r *= 0.23f;
                g *= 0.25f;
                b *= 0.00f;
            }
        }
    }

    internal class GoldenStinkNPC : GlobalNPC
    {
        public bool goldenStink = false;

        public override bool InstancePerEntity => true;

        public override void ResetEffects(NPC npc)
        {
            goldenStink = false;
        }

        public override void DrawEffects(NPC npc, ref Color drawColor)
        {
            if (goldenStink)
            {
                drawColor.R *= (byte)0.23f;
                drawColor.G *= (byte)0.25f;
                drawColor.B *= (byte)0.00f;
            }
        }
    }
}
