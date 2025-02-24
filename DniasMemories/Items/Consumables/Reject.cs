using System;
using DniasMemories.Buffs;
using Mono.CompilerServices.SymbolWriter;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Consumables
{
    public class Reject : ModItem
    {

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 28;
            Item.useStyle = ItemUseStyleID.HoldUp;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item4; // Default drink sound
            Item.consumable = false;
            Item.maxStack = 30;
            Item.value = Item.buyPrice(0, 0, 3, 0);
            Item.rare = ItemRarityID.Blue;
            Item.buffType = ModContent.BuffType<Rejection>();
            Item.buffTime = 31536000; // 60 = 1 seconds
            Item.vanity = true;
            Item.accessory = true;
            
            
            
            
        }

        /*public override bool CanUseItem(Player player)
        {
            return !player.HasBuff(ModContent.BuffType<Rejection>()); // Check if the player already has the buff
        }

        public override bool? UseItem(Player player) 
        {
            player.AddBuff(ModContent.BuffType<Rejection>(), 31536000); // 60 = 1 seconds
            
            return false;
            
        }*/

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.AddBuff(ModContent.BuffType<Rejection>(), 1);
        }

        public override void UpdateVanity(Player player)
        {
            player.AddBuff(ModContent.BuffType<Rejection>(), 1);
        }


        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.BottledWater)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}
