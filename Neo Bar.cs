using Xtraarmory.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class NB : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Neo Bar"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("it shines in a spectacular glow");
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
			recipe.AddIngredient(ItemID.CrystalShard, 5);
			recipe.AddIngredient(ItemID.Torch, 5);
			recipe.AddIngredient(ItemID.LunarOre, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}