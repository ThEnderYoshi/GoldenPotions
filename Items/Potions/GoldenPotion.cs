using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;
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

        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance
                    .SacrificeCountNeededByItemId[Type] = 1;
            SafeStaticDefaults();
        }

        public override void SetDefaults()
        {
            Item.useStyle = ItemUseStyleID.DrinkLiquid;
            Item.useAnimation = 17;
            Item.useTime = 17;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item3;

            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = ModContent.RarityType<GoldenRarity>();
            Item.value = Item.sellPrice(silver: 4);
            SafeDefaults();
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
        /// Use this instead of <see cref="SetStaticDefaults"/>.
        /// </summary>
        public virtual void SafeStaticDefaults() {}
        /// <summary>
        /// <para>Use this instead of <see cref="SetDefaults"/>.</para>
        /// <para>You mainly just need to set Item.width,
        /// Item.height, and Item.value.</para>
        /// </summary>
        public virtual void SafeDefaults() {}
    }
}
