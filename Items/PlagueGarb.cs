using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Body)]
    public class PlagueGarb : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Plague Garb");
			Tooltip.SetDefault("Still work in progress\nVanity made by Canis\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   
            item.rare = 1;    
            item.vanity = true;
			item.value = 4000;
        }
		
		public override void SetMatch(bool male, ref int equipSlot, ref bool robes) {
			robes = true;
			// The equipSlot is added in ExampleMod.cs --> Load hook
			equipSlot = mod.GetEquipSlot("PlagueGarb_Legs", EquipType.Legs);
			
		}
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = false;
			drawArms = false;		
        }
		public override bool DrawBody()
        {
            return false;    
        }
		public override bool DrawLegs()
        {
            return false;    
        }
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddIngredient(ItemID.BlackThread, 4);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
