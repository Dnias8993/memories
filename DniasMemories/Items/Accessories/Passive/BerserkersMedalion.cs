using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.Passive
{
    public class BerserkersMedalion : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
       

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(0, 2, 0, 0);
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife < player.statLifeMax2)
            {
                float x = (player.statLifeMax2 - player.statLife) * 0.005f;
                player.GetDamage(DamageClass.Generic) += x;
            }
            else
            {
                player.GetDamage(DamageClass.Generic) += 0.1f;
            }
            

        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.CrimtaneBar, 10);
            recipe.AddIngredient(ItemID.Bone, 10);
            recipe.AddIngredient(ItemID.Chain, 3);
            recipe.AddIngredient<Items.skillpoint>(1);
            recipe.AddTile(TileID.Anvils);
            recipe.Register();
        }
    }
}