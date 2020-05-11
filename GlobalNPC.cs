using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Events;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace VanityContest
{
	class MyGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if(npc.type == NPCID.WitchDoctor)
			{
				if (Main.rand.NextFloat() < .2000f)
					Item.NewItem(npc.getRect(), mod.ItemType("KindredSpirit"));
			}
			if(npc.type == NPCID.Zombie)
			{
				if (Main.rand.NextFloat() < .3333f)
					Item.NewItem(npc.getRect(), mod.ItemType("Traffic"));
			}
			// Addtional if statements here if you would like to add drops to other vanilla npc.
		}
		
		public override void SetupShop(int type, Chest shop, ref int nextSlot) {
			if (type == NPCID.Clothier) {
				shop.item[nextSlot].SetDefaults(mod.ItemType("orangeThread"));
				shop.item[nextSlot].shopCustomPrice = 8000;
				nextSlot++;
			}
			if (BirthdayParty.ManualParty || BirthdayParty.GenuineParty) {
				if (type == NPCID.Clothier) {
					shop.item[nextSlot].SetDefaults(mod.ItemType("tirolerBody"));
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;

					shop.item[nextSlot].SetDefaults(mod.ItemType("tirolerLegs"));
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;

					shop.item[nextSlot].SetDefaults(mod.ItemType("tirolerHead"));
					shop.item[nextSlot].shopCustomPrice = 10000;
					nextSlot++;
				}
			}
		}		
	}
}