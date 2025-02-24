using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories.skins
{
    public class terraskin : ModItem
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
            player.statDefense += 15;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.Chilled] = true;
            player.buffImmune[BuffID.Frozen] = true;
            player.buffImmune[BuffID.Suffocation] = true;
            player.frostBurn = true;
            player.lavaImmune = true;
            player.ignoreWater = true;
            player.accFlipper = true;
            player.pickSpeed -= 2.0f;
            player.endurance += .1f;
            player.nightVision = true;
            player.magmaStone = true;
            player.noFallDmg = true;
            player.maxRunSpeed += 0.2f;
            player.runAcceleration += 0.2f;
            player.accRunSpeed += 0.2f;
            player.GetDamage(DamageClass.Generic) += .15f;
            player.GetAttackSpeed(DamageClass.Generic) += .3f;
            

                        
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient<Items.Accessories.skins.stoneskin>(1);
            recipe.AddIngredient<Items.Accessories.skins.windskin>(1);
            recipe.AddIngredient<Items.Accessories.skins.waterskin>(1);
            recipe.AddIngredient<Items.Accessories.skins.woodskin>(1);
            recipe.AddIngredient<Items.Accessories.skins.magmaskin>(1);
            recipe.AddIngredient<Items.Accessories.skins.frozenskin>(1);
            recipe.AddIngredient(ItemID.ChlorophyteBar,10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }
    

    }
}