using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items
{
	public class ET : ModItem
	{
		public override void SetStaticDefaults() 
		{
			 DisplayName.SetDefault("Element Totem"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("you can feel it's power");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.accessory = true;
            item.defense = 5;
		}
		
		public override void UpdateEquip(Player player) {
			player.maxMinions++;
			player.maxMinions++;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CT", 1 );
			recipe.AddIngredient(mod,"toxictotem", 1 );
			recipe.AddIngredient(mod,"CAT", 1 );
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}