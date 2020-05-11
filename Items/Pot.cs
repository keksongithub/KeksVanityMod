using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class Pot : ModItem
    {	
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pot Head");
			Tooltip.SetDefault("Vanity main idea by PotpanTheMighty\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
			item.createTile = mod.TileType("PotTile");
            item.width = 18; 
            item.height = 18; 
			item.maxStack = 1;			
            item.rare = 1;    
            item.defense = 1;
			item.useTime = 14;
            item.useAnimation = 17;
			item.useStyle = 1;
			item.value = 1000;
            item.useTurn = true;
            item.autoReuse = true;
			item.consumable = true;
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
    }
}
