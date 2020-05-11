using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using VanityContest.Items.VanityAssets;
using static Terraria.ModLoader.ModContent;

namespace VanityContest
{
	public class VanityContest : Mod
	{
		public VanityContest()
		{
		}
		
		public override void Load() {
			// All code below runs only if we're not loading on a server
			if (!Main.dedServ) {
				// Add certain equip textures
				AddEquipTexture(null, EquipType.Legs, "PlagueGarb_Legs", "VanityContest/Items/VanityAssets/PlagueGarb_Legs");
			}
		}

		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Iron", new int[]
			{
				ItemID.IronBar,
				ItemID.LeadBar
			});
			RecipeGroup.RegisterGroup("VanityContest:Iron", group);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(this);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddRecipeGroup("VanityContest:Iron", 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemType("Pot"));
			recipe.AddRecipe();
		}
	}
}