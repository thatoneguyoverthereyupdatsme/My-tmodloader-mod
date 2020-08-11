
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class FBS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Frostbite Staff");
			Tooltip.SetDefault("cold!");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.magic = true;
			item.melee = false;
			item.width = 100;
			item.height = 100;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("FBB");
			item.shootSpeed = 9f;
			item.mana = 5;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CS",1);
			recipe.AddIngredient(mod,"SS",1);
			recipe.AddIngredient(mod,"IS",1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}