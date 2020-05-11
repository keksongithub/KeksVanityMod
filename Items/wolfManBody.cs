using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Body)]
    public class wolfManBody : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Umbren Bodywear");
			Tooltip.SetDefault("Vanity made by Umbren45 and sn0wys\n′Great for impersonating community members!′");						
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   
            item.rare = 5;    
            item.vanity = true;
        }
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = false;
			drawArms = true;		
        }
		public override bool DrawBody()
        {
            return true;    
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 8);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
