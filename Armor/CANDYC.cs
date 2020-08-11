
using Xtraarmory.Tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class CANDYC : ModItem
	{
		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			DisplayName.SetDefault("Candy breastplate");
			Tooltip.SetDefault("Sticky, your range ability feels it's getting better");
		}

		public override void SetDefaults() {
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 5;
		}
		public override void UpdateEquip(Player player) {
			player.rangedDamage += 0.1f;
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"CAB",10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}