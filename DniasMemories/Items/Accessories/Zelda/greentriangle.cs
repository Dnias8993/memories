using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class greentriangle : ModItem
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
            player.GetDamage(DamageClass.Generic) += 0.2f;
            player.lifeRegen += 8;
            player.manaRegen += 8;
            player.pickSpeed -= 0.3f;
            player.statDefense += 10;
            player.GetCritChance(DamageClass.Generic) += 10;
            player.GetAttackSpeed(DamageClass.Generic) += 0.3f;
            player.moveSpeed += 0.2f;
            player.noKnockback = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.Zelda.forestgem>(1);
            recipe.AddIngredient(ItemID.SoulofFright, 50);
            recipe.AddIngredient(ItemID.LifeFruit, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

    }
}