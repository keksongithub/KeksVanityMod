using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class wolfMan : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Umbren Headgear");
			Tooltip.SetDefault("Vanity made by Umbren45 and sn0wys\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   
            item.rare = 5;    
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return true;    
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;
			drawAltHair = false;  
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 5);
			//recipe.AddIngredient(mod.ItemType("purpleThread"), 3);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
