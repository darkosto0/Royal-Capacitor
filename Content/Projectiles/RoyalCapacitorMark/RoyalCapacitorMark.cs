using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Content.Projectiles.RoyalCapacitorMark
{
    public class RoyalCapacitorMark : ModProjectile
    {
        public static Vector2 MousePosition = Main.MouseWorld;

        public override void SetStaticDefaults()
        {
            Projectile.height = 82;
            Projectile.width = 82;
            Projectile.friendly = true;
            Projectile.penetrate = -1;
            Projectile.damage = 0;
            Projectile.scale = 1f;
        }

        private NPC GetNearestEnemy(Vector2 position)
        {
            NPC nearestEnemy = null;
            float minDistance = float.MaxValue;

            foreach (NPC enemy in Main.npc)
            {
                if (enemy.active && !enemy.friendly)
                {
                    float distance = Vector2.Distance(MousePosition, enemy.position);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        nearestEnemy = enemy;
                    }
                }
            }

            return nearestEnemy;
        }

        public override void AI()
        {
            NPC nearestEnemy = GetNearestEnemy(MousePosition);

            if (nearestEnemy != null)
            {
                Projectile.position = nearestEnemy.position;
            }
        }
    }
}
