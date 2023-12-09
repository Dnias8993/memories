using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace DniasMemories.Items.Accessories
{
    public class forestgem : ModItem
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
            player.GetDamage(DamageClass.Generic) += 0.1f;
            player.lifeRegen += 4;
            player.manaRegen += 4;
            player.pickSpeed += 0.15f;
            player.GetCritChance(DamageClass.Generic) += 5;
            player.GetAttackSpeed(DamageClass.Generic) += 0.1f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Emerald, 15);
            recipe.AddIngredient(ItemID.GoldBar, 5);
            recipe.AddIngredient(ItemID.FallenStar, 15);
            recipe.AddTile(TileID.Hellforge);
            recipe.Register();
        }

    }
}