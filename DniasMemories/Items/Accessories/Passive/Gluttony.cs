/*using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.Passive
{
    public class Gluttony : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
       

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(gold: 1);
            Item.rare = ItemRarityID.Green;
            Item.accessory = true;
        }
        

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            

        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.skillpoint>(5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}*/