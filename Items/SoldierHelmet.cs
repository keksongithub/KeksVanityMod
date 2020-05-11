using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class SoldierHelmet : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soldier Helmet");
			Tooltip.SetDefault("Immunity to Broken Armor\nVanity made by FritzH\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   
            item.rare = 3;
			item.defense = 4;			
			item.value = 3000;			
            item.vanity = false;
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
		public override void UpdateEquip(Player player) {
			player.buffImmune[BuffID.BrokenArmor] = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("VanityContest:Iron", 4);
			recipe.AddIngredient(ItemID.JungleSpores, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}
