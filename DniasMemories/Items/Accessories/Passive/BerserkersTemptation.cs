using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.Passive
{
    public class BerserkersTemptation : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
       

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
            Item.value = Item.buyPrice(0, 7, 0, 0);
            Item.accessory = true;
            Item.rare = ItemRarityID.Blue;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (player.statLife >= (int)(player.statLifeMax2 * .5f))
            {
                int x = (int)(player.statLifeMax2 * .1f);
                player.lifeRegen -= x;
            }
            
            if (player.statLife < player.statLifeMax2)
            {
                float y = (player.statLifeMax2 - player.statLife) * 0.005f;
                player.GetDamage(DamageClass.Generic) += y;
            }
            
            

        }
        
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Accessories.Passive.BerserkersMedalion>(1);
            recipe.AddIngredient<Items.skillpoint>(3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}