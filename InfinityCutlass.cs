
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class InfinityCutlass : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Infinity Cutlass");
			Tooltip.SetDefault("it looks amazing");
		}

		public override void SetDefaults() 
		{
			item.damage = 250;
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
			item.shoot = mod.ProjectileType("Star");
			item.shootSpeed = 9f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"NB",1);
			recipe.AddIngredient(mod,"NeoCutlass",1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}