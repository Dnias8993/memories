using System;
using DniasMemories.Buffs;
using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Consumables
{
    public class FoodOfTheWild : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 48;
            Item.height = 48;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2; 
            Item.consumable = true;
            Item.maxStack = 64;
            Item.value = 800;
            Item.rare = ItemRarityID.Blue;
        }

        public override bool CanUseItem(Player player)
        {
            return true;
        }

        public override bool? UseItem(Player player) 
        {
           
            player.HealEffect(50);
            player.statLife += 50;
            return true;
            
        }
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.Acorn, 5)
                .AddIngredient(ItemID.Mushroom, 2)
                .AddIngredient(ItemID.Pumpkin, 5)
                .AddTile(TileID.CookingPots)
                .Register();
        }
    }
}
