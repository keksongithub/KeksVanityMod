using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class Traffic : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Traffic Head");
			Tooltip.SetDefault("Vanity main idea by @SeanSeanSeanSe\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;   
            item.rare = 2;    
            item.vanity = true;
			item.value = 2000;
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
