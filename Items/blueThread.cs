using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanityContest.Items
{
    public class blueThread : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Blue Thread");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 200;
            item.rare = 0;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Waterleaf, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}