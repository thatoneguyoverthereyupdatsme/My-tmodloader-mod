
using Xtraarmory.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class WS : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Wrath Staff");
			Tooltip.SetDefault("cool!");
		}

		public override void SetDefaults() 
		{
			item.damage = 18;
			item.magic = true;
			item.melee = false;
			item.width = 100;
			item.height = 100;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("WPBM");
			item.shootSpeed = 9f;
			item.mana = 3;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WrathPotion, 1);
			recipe.AddIngredient(mod, "ISS", 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}