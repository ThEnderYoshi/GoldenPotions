using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace GoldenPotions
{
	public class GoldenPotions : Mod
	{
        public override void AddRecipeGroups()
        {
            // Any Golden Critter
            RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Golden Critter", new int[]
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
                ItemID.SquirrelGold
            });
            RecipeGroup.RegisterGroup("GoldenPotions:GoldenCritters", group);
        }

        public override void AddRecipes()
        {
            // Vanilla health potions
            PotionUpgrate(ItemID.LesserHealingPotion, ItemID.HealingPotion);
            PotionUpgrate(ItemID.HealingPotion, ItemID.GreaterHealingPotion);
            PotionUpgrate(ItemID.GreaterHealingPotion, ItemID.SuperHealingPotion);

            // Vanilla mana potions
            PotionUpgrate(ItemID.LesserManaPotion, ItemID.ManaPotion);
            PotionUpgrate(ItemID.ManaPotion, ItemID.GreaterManaPotion);
            PotionUpgrate(ItemID.GreaterManaPotion, ItemID.SuperManaPotion);

            // Vanilla luck potions
            PotionUpgrate(ItemID.LuckPotionLesser, ItemID.LuckPotion);
            PotionUpgrate(ItemID.LuckPotion, ItemID.LuckPotionGreater);
        }

        /// <summary>
        /// Creates the recipe [prevTier] + Any Golden Critter on Bottle = [nextTier]
        /// </summary>
        /// <param name="prevTier">The ingredient potion.</param>
        /// <param name="nextTier">The resulting potion.</param>
        private void PotionUpgrate(int prevTier, int nextTier)
        {
            Recipe.Create(nextTier)
                    .AddIngredient(prevTier)
                    .AddRecipeGroup("GoldenPotions:GoldenCritters")
                    .AddTile(TileID.Bottles)
                    .Register();
        }
    }
}