using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;

namespace VanityContest.Items.VanityAssets   //We need this to basically indicate the folder where it is to be read from, so you the texture will load correctly
{
	[AutoloadEquip(EquipType.Legs)]
    public class tirolerLegs : ModItem
    {		
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Lederhosen");
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
    }
}
