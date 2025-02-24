using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.DataStructures;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class bluetriangle : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.accessory = true;
            Item.width = 40;
            Item.height = 40;
            Item.value = 1000;
            
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Magic) += 0.1f;
            player.statManaMax2 += 100;
            player.manaRegen += 7;
            player.GetCritChance(DamageClass.Magic) += 10;
            player.ignoreWater = true;
            player.accFlipper = true;
            player.breathMax = 400;
            player.GetDamage(DamageClass.Generic) += 0.15f;
            player.lifeRegen += 2;
            player.pickSpeed -= 0.2f;
            player.GetAttackSpeed(DamageClass.Generic) += 0.2f;
            player.statDefense += 5;
            player.moveSpeed += 0.2f;
            player.noKnockback = true;

                     

        }
        

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.Zelda.watergem>(1);
            recipe.AddIngredient(ItemID.SoulofSight, 50);
            recipe.AddIngredient(ItemID.CrystalShard, 25);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    }
}