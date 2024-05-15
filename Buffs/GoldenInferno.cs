using GoldenPotions.Players;
using Microsoft.Xna.Framework;
using System.Runtime.CompilerServices;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;

namespace GoldenPotions.Buffs
{
    internal class GoldenInferno : GoldenBuff
    {
        private const int DamageDealt = 10;
        private const float DamageRadius = 200f;
        private const float DamageRadiusSquared = DamageRadius * DamageRadius;

        private const int DebuffId = BuffID.OnFire3;
        private const int DebuffDuration = 2 * 60; // In frames.

        private static readonly Vector3 LightEmitted = new(0.9f, 0.8f, 0.2f);

        public override int OverwriteBuff => BuffID.Inferno;

        public override void Update(Player source, ref int buffIndex)
        {
            base.Update(source, ref buffIndex);

            GoldenPotionsPlayer modPlayer = source.GetModPlayer<GoldenPotionsPlayer>();
            modPlayer.GoldenInferno = true;
            bool shouldApplyDamage = modPlayer.GoldenInfernoCounter % 60 == 0;
            Lighting.AddLight(source.position, LightEmitted);

            if (source.whoAmI == Main.myPlayer)
            {
                AffectNpcs(source, shouldApplyDamage);
                AffectPlayers(source, shouldApplyDamage);
            }
        }

        private static void AffectNpcs(Player source, bool shouldApplyDamage)
        {
            foreach (var target in Main.ActiveNPCs)
            {
                if (!CanDamageNpc(target, source))
                    continue;

                if (!target.HasBuff(DebuffId))
                    target.AddBuff(DebuffId, DebuffDuration);

                if (shouldApplyDamage)
                    source.ApplyDamageToNPC(target, DamageDealt, 0f, 0);
            }
        }

        private static void AffectPlayers(Player source, bool shouldApplyDamage)
        {
            if (!source.hostile)
                return;

            foreach (var target in Main.ActivePlayers)
            {
                if (!CanDamagePlayer(source, target))
                    continue;

                if (!target.HasBuff(DebuffId))
                    target.AddBuff(DebuffId, DebuffDuration);

                if (!shouldApplyDamage)
                    continue;

                target.Hurt(PlayerDeathReason.LegacyEmpty(), DamageDealt, 0);

                // Wait, why should this ever run in singleplayer?
                if (Main.netMode == NetmodeID.SinglePlayer)
                    continue;

                var info = new Player.HurtInfo
                {
                    Damage = DamageDealt,
                    DamageSource = PlayerDeathReason.ByOther(16),
                    PvP = true,
                    DustDisabled = true,
                };

                NetMessage.SendPlayerHurt(target.whoAmI, info);
            }
        }

        //NOTE: Assumes the NPC is active.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool CanDamageNpc(NPC target, Player source)
        {
            return !target.friendly
                && target.damage > 0
                && !target.dontTakeDamage
                && !target.buffImmune[DebuffId]
                //TODO: Find alternative(?) to Player.this.CanNPCBeHitByPlayerOrPlayerProjectile
                && Vector2.DistanceSquared(source.Center, target.Center) <= DamageRadiusSquared;
        }

        //NOTE: Assumes the player is active.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool CanDamagePlayer(Player source, Player target)
        {
            return target.whoAmI != source.whoAmI
                && !target.dead
                && target.hostile
                && !target.buffImmune[DebuffId]
                && (target.team != source.team || target.team == 0)
                && Vector2.DistanceSquared(source.Center, target.Center) <= DamageRadius;
        }
    }
}
