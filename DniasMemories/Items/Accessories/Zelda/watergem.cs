using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class watergem : ModItem
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
            player.ignoreWater = true;
            player.accFlipper = true;
            player.breathMax = 400;
            player.statManaMax2 += 60;
            player.manaRegen += 5;
            player.GetDamage(DamageClass.Magic) += 0.1f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Sapphire, 15);
            recipe.AddIngredient(ItemID.GoldBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 15);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

    }
}