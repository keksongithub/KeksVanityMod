using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Localization;
using Terraria.ObjectData;
using Terraria.Enums;
using Terraria.DataStructures;

using static Terraria.ModLoader.ModContent;

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace VanityContest.Tiles.TileAssets
{
	public class PotTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = false; 
            Main.tileFrameImportant[Type] = true; 
            Main.tileTable[Type] = true;
			Main.tileNoAttach[Type] = true;
			
			//----------
			
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new int[] { 18 };
			
			
			TileObjectData.newTile.Direction = TileObjectDirection.PlaceRight;
			TileObjectData.newAlternate.CopyFrom(TileObjectData.newTile);
			TileObjectData.newAlternate.Direction = TileObjectDirection.PlaceLeft; 
			TileObjectData.addAlternate(1);

			TileObjectData.newTile.Origin = new Point16(1, 0);			
			
            TileObjectData.addTile(Type);
			
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Pot");
			AddMapEntry(new Color(110, 110, 110), name);
			
            adjTiles = new int[] { TileID.CookingPots }; 
            disableSmartCursor = true;
		}
        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("Pot"));
        }		
	}
}