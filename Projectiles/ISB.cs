using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Xtraarmory.Projectiles
{
	public class ISB : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Ironskin Beam");
		}

		public override void SetDefaults() {
			projectile.width = 100;
			projectile.height = 100;
			projectile.alpha = 0;
			projectile.timeLeft = 600;
			projectile.penetrate = -1;
			projectile.friendly = true;
			projectile.magic = true;
			projectile.light = 5f;  
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}
		public override void AI()         
        {                                                         
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
		
	}
}