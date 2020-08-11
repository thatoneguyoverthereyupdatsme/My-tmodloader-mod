using Xtraarmory.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CANDYH : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Candy Hood");
			Tooltip.SetDefault("Sticky, your range ability feels it's getting better");
		}
		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.1f;
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 5;
		}
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CBA",25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}