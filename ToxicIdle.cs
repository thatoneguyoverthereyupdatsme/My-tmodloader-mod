using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class ToxicIdle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Toxic Cross");
			Tooltip.SetDefault("cool");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = false;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 4;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("TB");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"Toxic_Bars",5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}