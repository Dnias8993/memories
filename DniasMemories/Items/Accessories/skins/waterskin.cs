using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.skins
{
    public class waterskin : ModItem
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
            player.statDefense += 5;
            player.accFlipper = true;
            player.ignoreWater = true;
            player.gills = true;
            if (player.wet)
            {
                player.moveSpeed += 0.4f;
                player.jumpSpeedBoost += 0.2f;
                player.AddBuff(BuffID.Shine, 2);
                player.nightVision = true;
            }          
            
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.skins.stoneskin>(1);
            recipe.AddIngredient(ItemID.Flipper, 1);
            recipe.AddIngredient(ItemID.Coral, 10);
            recipe.AddIngredient(ItemID.BottledWater, 100);
            recipe.AddTile(TileID.WaterFountain);
            recipe.Register();
        }
    }
}