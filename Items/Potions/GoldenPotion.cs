using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using GoldenPotions.Rarities;

namespace GoldenPotions.Items.Potions
{
    public abstract class GoldenPotion : ModItem
    {
        /// <summary>
        /// <para>The ID of potion used to craft this.</para>
        /// <para>Use <see cref="ItemID"/>.</para>
        /// </summary>
        abstract public int NormalPotion { get; }

        public override void SetDefaults()
        {
            PreDefaults();
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;

            Item.maxStack = 9999;
            Item.consumable = true;
            Item.rare = ModContent.RarityType<GoldenRarity>();
            Item.value = Item.sellPrice(silver: 4);
            SafeDefaults();
        }

        public override void UseStyle(Player player, Rectangle heldItemFrame)
        {
            var mouthPos = new Vector2(
                player.position.X + (player.direction > 0 ? 14f : 2f) + Main.rand.NextFloat(5f),
                player.position.Y + 13f + Main.rand.NextFloat(5f));

            Dust.NewDustPerfect(mouthPos, DustID.FoodPiece, Vector2.Zero, 0, new Color(203, 179, 73));
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(NormalPotion)
                .AddRecipeGroup("GoldenPotions:GoldenCritters")
                .AddTile(TileID.Bottles)
                .Register();
        }

        /// <summary>
        /// Called at the start of <see cref="SetDefaults"/>.
        /// </summary>
        public virtual void PreDefaults() { }

        /// <summary>
        /// <para>Use this instead of <see cref="SetDefaults"/>.</para>
        /// <para>You mainly just need to set Item.width,
        /// Item.height, and Item.value.</para>
        /// </summary>
        public virtual void SafeDefaults() { }
    }
}
