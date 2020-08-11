using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class Toxic_Bars : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Toxic Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Beggining");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ExampleOre");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}