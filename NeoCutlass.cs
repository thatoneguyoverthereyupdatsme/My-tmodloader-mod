using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class NeoCutlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Neo Cutlass");
			Tooltip.SetDefault("it looks magestic");
		}

		public override void SetDefaults() 
		{
			item.damage = 200;
			item.melee = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"NB",5);
			recipe.AddIngredient(mod,"ToxicCutlass",1);
			recipe.AddIngredient(ItemID.Cutlass, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}