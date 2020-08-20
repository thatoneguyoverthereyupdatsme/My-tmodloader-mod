

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace Xtraarmory.NPC
{
	public class CASP : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Candy Spirit");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 46;
			npc.damage = 4;
			npc.defense = 12;
			npc.npcSlots = 1;
			npc.lifeMax = 90;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 100;
			npc.knockBackResist = 0.3f;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.aiStyle = 22;
			aiType = NPCID.Wraith;
			animationType = NPCID.Wraith;
			npc.stepSpeed = .5f;
			npc.lavaImmune = true;
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("CAB"), 2 + Main.rand.Next(3));
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 2.5f;
		}
	}
}