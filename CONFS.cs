using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class CONFS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Confetti summon Staff");
			Tooltip.SetDefault("WOOOOOOOOOOOOO");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.melee = false;
			item.summon = true;
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
			item.shoot = ProjectileID.PartyBullet;

		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"STS",1);
			recipe.AddIngredient(ItemID.Confetti, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}