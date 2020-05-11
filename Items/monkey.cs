using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class monkey : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Monkey Head");
			Tooltip.SetDefault("Vanity made by Canis\n′Great for impersonating community members!′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;  
			item.maxStack = 1;			
            item.rare = 0;    
            item.vanity = true;
			item.value = 6000;
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
