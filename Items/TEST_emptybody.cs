using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.TEST   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Body)]
    public class TEST_emptybody : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("TEST_emptybody");
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
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
			drawArms = true;		
        }
		public override bool DrawBody()
        {
            return true;    
        }
    }
}
