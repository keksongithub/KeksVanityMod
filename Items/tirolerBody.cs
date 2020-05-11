using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Body)]
    public class tirolerBody : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lederweste");
			Tooltip.SetDefault("′From the 3DS version′");			
		}
		
        public override void SetDefaults()
        {
            item.width = 18; 
            item.height = 18;  		
            item.rare = 4;    
			item.maxStack = 1;
			item.value = 400;
            item.vanity = true;
        }
		public override void DrawHands(ref bool drawHands, ref bool drawArms)
        {
            drawHands = true;
			drawArms = false;		
        }
		public override bool DrawBody()
        {
            return true;    
        }
    }
}
