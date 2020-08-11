using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Projectiles
{
	public class IB : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Toxic Ball");
		}

		public override void SetDefaults() {
			projectile.width = 20;
			projectile.height = 20;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}
		public override void AI()         
        {                                                         
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 199.57f;
        }
		
	}
}