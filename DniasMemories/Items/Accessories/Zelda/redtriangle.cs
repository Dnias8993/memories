using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class redtriangle : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = 1000;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Melee) += 0.1f;
            player.statDefense += 7;
            player.pickSpeed -= 0.2f;
            player.GetCritChance(DamageClass.Generic) += 7;
            player.GetAttackSpeed(DamageClass.Generic) += 0.2f;
            player.lifeRegen += 2;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;            
            player.GetDamage(DamageClass.Generic) += 0.15f;
            player.lavaImmune = true;
            player.moveSpeed += 0.2f;
            player.magmaStone = true;
            player.noKnockback = true;
            if (player.lavaWet)
            {
                player.ignoreWater = true;
                player.accFlipper = true;
            }
            
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.Zelda.firegem>(1);
            recipe.AddIngredient(ItemID.SoulofMight, 50);
            recipe.AddIngredient(ItemID.HallowedBar, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}