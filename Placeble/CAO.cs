using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Items.Placeble
{
	public class CAO : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Ore");
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
			item.createTile = TileType<Tiles.CAO>();
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
}