using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class NatureSword1 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Flower sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Cool! and shoots tiny seeds");
		}

		public override void SetDefaults() 
		{
			item.damage = 8;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.UseSound = SoundID.Item11;
			item.shoot = mod.ProjectileType("ElementBall");
			item.shootSpeed = 16f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "NatureSword");
			recipe.AddIngredient(ItemID.Sunflower, 5);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}