using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class ToxicCutlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Toxic Cutlass");
			Tooltip.SetDefault("It feels like getting hand sanitizer in a cut to get sliced by this");
		}

		public override void SetDefaults() 
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 7;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("TB");
			item.shootSpeed = 9f;
			item.autoReuse = true;
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