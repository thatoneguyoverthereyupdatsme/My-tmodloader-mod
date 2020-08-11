using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class TS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Toxic Wand");
			Tooltip.SetDefault("It feels like getting hand sanitizer in a cut to get sliced by this");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = false;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 4;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 9f;
			item.autoReuse = true;
			item.noMelee = true; 
			item.noUseGraphic = true; 
			item.autoReuse = true; 
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