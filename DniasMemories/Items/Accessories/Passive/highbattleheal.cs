using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.Passive
{
    public class highbattleheal : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        public int Timmer = 0;

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = 1000;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            Timmer++;
            if(Timmer > 180)
            {
                player.statLife += player.statLifeMax2 / 20;
                player.HealEffect(player.statLifeMax2 / 20);
                Timmer = 0;

            }   

        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.skillpoint>(5);
            recipe.AddIngredient<Items.Accessories.Passive.battleheal>(1);
            recipe.AddTile(TileID.CrystalBall);
            recipe.Register();   
        }
        


    }
}