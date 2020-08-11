
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class CS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Cryo Staff");
			Tooltip.SetDefault("cold!");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.magic = true;
			item.melee = false;
			item.width = 100;
			item.height = 100;
			item.useTime = 13;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("CB");
			item.shootSpeed = 9f;
			item.mana = 5;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CBA",5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}