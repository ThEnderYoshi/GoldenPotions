using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace GoldenPotions
{
    internal class GoldenPotionsPlayer : ModPlayer
    {
        public bool goldenAmmoReservation = false;
        public bool goldenArchery = false;
        public bool goldenEndurance = false;

        public override void ResetEffects()
        {
            goldenAmmoReservation = false;
            goldenArchery = false;
            goldenEndurance = false;
        }

        // -- Testers -- //

        public override bool CanConsumeAmmo(Item weapon, Item ammo)
        {
            return !goldenAmmoReservation || Main.rand.NextFloat() > 0.4f;
        }

        // -- Modifiers -- //
        //TODO: Modify all damage sources to account for Endurance++
        //      (At least, all damage sources accounted for by regular Endurance)

        public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
        {
            ApplyGoldenEndurance(ref damage);
        }

        public override void ModifyHitByProjectile(Projectile proj, ref int damage, ref bool crit)
        {
            ApplyGoldenEndurance(ref damage);
        }

        public override void ModifyHitPvp(Item item, Player target, ref int damage, ref bool crit)
        {
            target.GetModPlayer<GoldenPotionsPlayer>().ApplyGoldenEndurance(ref damage);
        }

        public override void ModifyShootStats(Item item, ref Vector2 position, ref Vector2 velocity, ref int type, ref int damage, ref float knockback)
        {
            if (goldenArchery)
            {
                velocity *= 1.4f;
                damage = (int)(damage * 1.4f);
            }
        }

        // -- Private -- //

        private void ApplyGoldenEndurance(ref int damage)
        {
            if (goldenEndurance)
            {
                damage = (int)(damage * 0.2f);
            }
        }
    }
}
