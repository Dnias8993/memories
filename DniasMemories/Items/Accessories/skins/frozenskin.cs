using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.skins
{
    public class frozenskin : ModItem
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
            player.statDefense += 7;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.frostBurn = true;
                        
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.skins.stoneskin>(1);
            recipe.AddIngredient(ItemID.Shiverthorn, 5);
            recipe.AddIngredient(ItemID.FlinxFur, 5);
            recipe.AddIngredient(ItemID.IceBlock, 200);
            recipe.AddTile(TileID.IceMachine);
            recipe.Register();
        }
    }
}