using Xtraarmory.Tiles;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.ID;

namespace Xtraarmory.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CANDYL : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Candy Leggings");
			Tooltip.SetDefault("Sticky, your range ability feels it's getting better");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.1f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CAB",30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}