using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using DniasMemories.Buffs;

namespace DniasMemories.Items.Weapons
{
    public class dniasscythe : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        
        public override void SetDefaults()
        {
            Item.damage = 72;
            Item.DamageType = DamageClass.Melee;
            Item.width = 70;
            Item.height = 70;
            Item.useTime = 5;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.knockBack = 12;
            Item.value = 10000;
            Item.rare = ItemRarityID.Purple;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.crit = 22;
            Item.ArmorPenetration = 15;

            
        }
        public override void OnHitNPC(Player player, NPC target, NPC.HitInfo hit, int damageDone)
        {
            
            player.Heal(damageDone / 10);
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


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
                
                if (player.altFunctionUse == 2)
                {
                    player.Teleport(Main.MouseWorld, 6);
                    Item.crit = 100;                                                  
                    
                }
                else
                {
                    Item.crit = 22;
                }
                return base.CanUseItem(player);
        }



        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.PortalGun, 1);
            recipe.AddIngredient(ItemID.LunarBar, 20);
            recipe.AddIngredient(ItemID.Wood, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.Register();
        }

    }
}
