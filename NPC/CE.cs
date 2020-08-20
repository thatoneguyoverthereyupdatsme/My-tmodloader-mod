using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;


namespace Xtraarmory.NPC
{
	public class CE : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cryo Eye");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.damage = 16;
			npc.defense = 16;
			npc.lifeMax = 200;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.aiStyle = 3;
			aiType = 434;
			animationType = 434;
		}

		public override void NPCLoot()
		{
				Item.NewItem(npc.getRect(), mod.ItemType("CBA"), 2 + Main.rand.Next(3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo){
			return SpawnCondition.OverworldDaySlime.Chance * 2.5f;
		}
	}
}
