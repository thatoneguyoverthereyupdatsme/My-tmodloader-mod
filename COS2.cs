
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class COS2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Confetti Staff 2.0");
			Tooltip.SetDefault("WOOOOOOOOOOOOOOOOOOOOOO!");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.magic = true;
			item.melee = false;
			item.width = 100;
			item.height = 100;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.PartyBullet;
			item.shootSpeed = 9f;
			item.mana = 5;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "COS", 1);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}