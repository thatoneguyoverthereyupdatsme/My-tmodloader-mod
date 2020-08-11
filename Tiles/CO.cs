using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Xtraarmory.Tiles
{
	public class CO : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; 
			Main.tileValue[Type] = 410; 
			Main.tileShine2[Type] = true; 
			Main.tileShine[Type] = 975; 
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cryo ore");
			AddMapEntry(new Color(152, 171, 198), name);

			dustType = 84;
			drop = ItemType<Items.Placeble.CO>();
			soundType = 21;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 20;
		}
	}
}