using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class Confetti_Sword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Confetti Sword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Confetti!!!!!!");
		}

		public override void SetDefaults() 
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
			item.shoot = ProjectileID.PartyBullet;
			item.shootSpeed = 16f;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "NatureSword1", 1);
			recipe.AddIngredient(ItemID.Confetti, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
