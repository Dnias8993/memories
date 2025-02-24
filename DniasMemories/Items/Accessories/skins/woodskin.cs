using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.skins
{
    public class woodskin : ModItem
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
            player.statDefense += 8;
            player.endurance += 0.05f;
            player.thorns = 1f;
            player.lifeRegen += 1;

            
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 100);
            recipe.AddIngredient<Items.Accessories.skins.stoneskin>(1);
            recipe.AddIngredient(ItemID.LivingWoodWand, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }

    }
}