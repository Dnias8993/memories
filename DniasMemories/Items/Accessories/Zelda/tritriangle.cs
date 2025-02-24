using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.Zelda
{
    public class tritriangle : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;
            Item.value = 10000;
            Item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.GetDamage(DamageClass.Generic) += 0.3f;
            player.statDefense += 20;
            player.pickSpeed -= 1f;
            player.GetCritChance(DamageClass.Generic) += 33;
            player.GetAttackSpeed(DamageClass.Generic) += 0.5f;
            player.lifeRegen += 10;
            player.manaRegen += 10;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Burning] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;           
            player.lavaImmune = true;
            player.moveSpeed += 0.5f;
            player.magmaStone = true;
            player.frostBurn = true;
            player.statManaMax2 += 160;
            player.ignoreWater = true;
            player.accFlipper = true;
            player.noKnockback = true;
            player.endurance += 0.1f;

            if (player.wet)
            {
                player.gills = true;
            }

            
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.Zelda.redtriangle>(1);
            recipe.AddIngredient<Items.Accessories.Zelda.bluetriangle>(1);
            recipe.AddIngredient<Items.Accessories.Zelda.greentriangle>(1);
            recipe.AddTile(TileID.Autohammer);
            recipe.Register();
        }
    }
}