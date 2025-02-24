using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace DniasMemories.Items.Accessories
{
    public class xchangehaex : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.width = 40;
            Item.height = 40;
            Item.value = 5000;
            
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            
            player.statLifeMax2 -= player.statLifeMax2*3/4;
            player.GetDamage(DamageClass.Generic) += 3.0f;            

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.xchangeha>(1);
            recipe.AddIngredient<Items.skillpoint>(5);
            recipe.AddTile(TileID.CrystalBall);
            recipe.Register();
        }
    }
}