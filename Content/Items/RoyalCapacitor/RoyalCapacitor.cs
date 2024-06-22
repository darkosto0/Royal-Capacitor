using Content.Projectiles.RoyalCapacitorMark;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace Content.RoyalCapacitor.Items.RoyalCapacitor
{
    public class RoyalCapacitor : ModItem
    {
        public static readonly SoundStyle Thunder1 = new SoundStyle("Content/Sounds/RoyalCapacitor/RoyalThunder1");
        public static readonly SoundStyle Thunder2 = new SoundStyle("Content/Sounds/RoyalCapacitor/RoyalThunder2");
        public static readonly SoundStyle Thunder3 = new SoundStyle("Content/Sounds/RoyalCapacitor/RoyalThunder3");
        public static readonly SoundStyle Thunder4 = new SoundStyle("Content/Sounds/RoyalCapacitor/RoyalThunder4");

        public bool HasCasted;

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.useTurn = true;
            Item.hasVanityEffects = false;
            Item.accessory = true;
            Item.crit = 100;
            Item.noMelee = true;
            Item.noUseGraphic = true;
        }
        public override void UpdateAccessory(Item item, Player player, bool hideVisual)
        {
            
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            Projectile.NewProjectile(player.GetSource_ItemUse(player.HeldItem), position, velocity, ModContent.ProjectileType<RoyalCapacitorMark>(), damage, knockback, player.whoAmI);

            if (Main.keyState.IsKeyDown(Keys.Q))
            {
                Projectile.NewProjectile(player.GetSource_ItemUse(player.HeldItem), position, velocity, ModContent.ProjectileType<Placeholder>(), damage, knockback, player.whoAmI);
            }
            return false;
        }
    }
}