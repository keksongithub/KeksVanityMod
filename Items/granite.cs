using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class granite : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Granite Light Cone");
			Tooltip.SetDefault("test");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;  		
            item.rare = 0;    
			item.maxStack = 1;
			item.value = 400;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;    
        }
        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            drawHair = false;
			drawAltHair = false;  
        }
    }
}
