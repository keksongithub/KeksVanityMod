using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using Terraria.ModLoader.Config.UI;
using Terraria.UI;

namespace VanityContest
{
	public class ModConfigServer : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ServerSide;
		
		
		[Label("Disable the DragonHead")]
		[Tooltip("Prevents Loading the Dragon Vanityset. Requires a Reload")]
		[ReloadRequired]
		public bool Disabledragonhead { get; set; }
		
		[Label("Disable the DragonLegs")]
		[Tooltip("Prevents Loading the Dragon Vanityset. Requires a Reload")]
		[ReloadRequired]
		public bool Disabledragonlegs { get; set; }
		
		[Label("Disable the DragonBody")]
		[Tooltip("Prevents Loading the Dragon Vanityset. Requires a Reload")]
		[ReloadRequired]
		public bool Disabledragonbody { get; set; }

	}
}