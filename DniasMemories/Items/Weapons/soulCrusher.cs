using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using DniasMemories.Buffs;

namespace DniasMemories.Items.Weapons
{
    public class soulCrusher : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.damage = 52;
            Item.DamageType = DamageClass.Melee;
            Item.width = 70;
            Item.height = 70;
            Item.useTime = 5;
            Item.useAnimation = 90;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 12;
            Item.value = 10000;
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.crit = 12;
            Item.ArmorPenetration = 50;

            
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            
            
            //delet this if broken
             if (!target.HasBuff(ModContent.BuffType<Hemorage>()))
                {
                target.AddBuff(ModContent.BuffType<Hemorage>(), 600);
                }
            else
            {
                target.AddBuff(ModContent.BuffType<Hemorage>(), 600);
            }
            
        }





        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 50);
            recipe.AddIngredient(ItemID.LifeFruit, 5);
            recipe.AddIngredient(ItemID.CrimsonHeart, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 30);
            recipe.AddIngredient(ItemID.FallenStar, 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

    }
}
