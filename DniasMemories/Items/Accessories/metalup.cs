using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories
{
    public class metalup : ModItem
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
            player.statDefense += 20;
            player.GetDamage(DamageClass.Generic) += 0.2f;
            player.moveSpeed -= 0.5f;
            player.ignoreWater = true;
            player.endurance += 0.2f;
            player.GetAttackSpeed(DamageClass.Generic) -= 0.3f;
            player.maxFallSpeed += 50f;
            if (player.wet)
            {
                player.gills = true;
            }
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.IronBar, 50);
            recipe.AddIngredient(ItemID.ArmorPolish, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

    }
}