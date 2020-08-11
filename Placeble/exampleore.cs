using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items.Placeble
{
	public class ExampleOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Acid Ore");
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = TileType<Tiles.ExampleOre>();
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
}