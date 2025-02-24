using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.skins
{
    public class windskin : ModItem
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
            player.moveSpeed += 0.1f;
            player.jumpSpeedBoost += 0.05f;
            player.maxRunSpeed += 0.05f;
            player.runAcceleration += 0.1f;
            player.accRunSpeed += 0.1f;
            player.noFallDmg = true;
            player.blackBelt = true;
           
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.skins.stoneskin>(1);
            recipe.AddIngredient(ItemID.Feather, 10);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddIngredient(ItemID.Cloud, 100);
            recipe.AddTile(TileID.SkyMill);
            recipe.Register();
        }
    }
}