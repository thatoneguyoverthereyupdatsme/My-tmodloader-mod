using Microsoft.Xna.Framework;
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class CAG : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Candy Gun");
			Tooltip.SetDefault("tasty!");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
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
			item.shoot = mod.ProjectileType("CA");
			item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.shootSpeed = 9f;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CAB",5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}