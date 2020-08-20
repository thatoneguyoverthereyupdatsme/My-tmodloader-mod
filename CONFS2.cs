using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Items
{
	public class CONFS2 : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Confetti Summon staff 2.0");
			Tooltip.SetDefault("WOOOOOOOOOOOOO");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
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
			recipe.AddIngredient(mod,"CONFS",1);
			recipe.AddIngredient(ItemID.SoulofLight, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}