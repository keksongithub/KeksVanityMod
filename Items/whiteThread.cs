using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace VanityContest.Items
{
    public class whiteThread : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("White Thread");
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
			recipe.AddIngredient(ItemID.Bone, 2);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}