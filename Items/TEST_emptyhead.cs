using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.TEST    //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Head)]
    public class TEST_emptyhead : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("TEST_emptyhead");
			Tooltip.SetDefault("For testing purpose only!!");		
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;  		
            item.rare = 0;    
			item.maxStack = 1;
			item.value = 0;
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
    }
}
