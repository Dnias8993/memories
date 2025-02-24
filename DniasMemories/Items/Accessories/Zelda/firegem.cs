using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class firegem : ModItem
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
            player.fireWalk = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.lavaMax = 1800;
            player.GetDamage(DamageClass.Melee) += 0.1f;
            player.buffImmune[BuffID.Burning] = true;
            player.magmaStone = true;
            if (player.lavaWet)
            {
                player.ignoreWater = true;
                player.accFlipper = true;
            }
            
            
        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Ruby, 15);
            recipe.AddIngredient(ItemID.GoldBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 15);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

    }
}