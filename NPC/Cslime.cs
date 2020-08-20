using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

using Microsoft.Xna.Framework;

namespace Xtraarmory.NPC
{
	public class Cslime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Confetti Slime");
			Main.npcFrameCount[npc.type] = 4;
		}

		public override void SetDefaults()
		{
			npc.lifeMax = 100;
			npc.damage = 10;
			npc.defense = 30;
			npc.knockBackResist = 0.3f;
			npc.width = 70;
			npc.alpha = 0;
			npc.height = 46;
			animationType = 244;
			npc.aiStyle = 1;
			aiType = 138;
			npc.npcSlots = 0.5f;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath23;
			npc.value = Item.buyPrice(0, 0, 12, 15);
		}

		public override void HitEffect(int hitDirection, double damage)
		{
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ItemID.Confetti, 5);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldDaySlime.Chance * 2.5f;
		}
	}
}