using Microsoft.Xna.Framework;
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class COFG : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Confetti Gun");
			Tooltip.SetDefault("WOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 100;
			item.height = 100;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileID.PartyBullet;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 9f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CAG",1);
			recipe.AddIngredient(ItemID.Confetti, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}