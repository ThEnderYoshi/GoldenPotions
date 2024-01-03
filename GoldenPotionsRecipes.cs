using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldenPotions
{
    /// <summary>
    /// Handles recipe groups and extra vanilla item recipes.
    /// </summary>
    internal class GoldenPotionsRecipes : ModSystem
    {

        public override void AddRecipeGroups()
        {
            //const string anyKey = "LegacyMisc.37";
            LocalizedText groupName =
                Language.GetText($"Mods.{nameof(GoldenPotions)}.RecipeGroups.AnyGoldenCritter");

            //var group = new RecipeGroup(() => $"{Language.GetTextValue(anyKey)} Golden Critter", new int[]
            var group = new RecipeGroup(() => groupName.Value, new int[]
            {
                ItemID.GoldBunny,
                ItemID.GoldBird,
                ItemID.GoldButterfly,
                ItemID.GoldDragonfly,
                ItemID.GoldFrog,
                ItemID.GoldGoldfish,
                ItemID.GoldGrasshopper,
                ItemID.GoldLadyBug,
                ItemID.GoldMouse,
                ItemID.GoldSeahorse,
                ItemID.GoldWaterStrider,
                ItemID.GoldWorm,
                ItemID.SquirrelGold,
            });
            RecipeGroup.RegisterGroup("GoldenPotions:GoldenCritters", group);
        }

        public override void AddRecipes()
        {
            CreateTierUpgradeRecipes(
                ItemID.LesserHealingPotion,
                ItemID.HealingPotion,
                ItemID.GreaterHealingPotion,
                ItemID.SuperHealingPotion
            );

            CreateTierUpgradeRecipes(
                ItemID.LesserManaPotion,
                ItemID.ManaPotion,
                ItemID.GreaterManaPotion,
                ItemID.SuperManaPotion
            );

            CreateTierUpgradeRecipes(
                ItemID.LuckPotionLesser,
                ItemID.LuckPotion,
                ItemID.LuckPotionGreater
            );
        }

        /// <summary>
        /// Creates recipes that allow the player to upgrade an item I to an item I + 1.
        /// </summary>
        /// <param name="tiers">The item IDs.</param>
        private static void CreateTierUpgradeRecipes(params int[] tiers)
        {
            for (int i = 0;  i < tiers.Length - 1; i++)
            {
                Recipe.Create(tiers[i + 1])
                    .AddIngredient(tiers[i])
                    .AddRecipeGroup("GoldenPotions:GoldenCritters")
                    .AddTile(TileID.Bottles)
                    .Register();
            }
        }
    }
}
