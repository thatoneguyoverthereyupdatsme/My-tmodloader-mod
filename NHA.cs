
using Xtraarmory.Tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class NHA : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded hamaxe.");
		}

		public override void SetDefaults() {
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 15;
			item.axe = 300000000;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 100000000; 
			item.pick = 230;      
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"NB",10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
}