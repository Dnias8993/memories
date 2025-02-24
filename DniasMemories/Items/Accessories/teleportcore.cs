using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.Creative;

namespace DniasMemories.Items.Accessories
{
    public class teleportcore : ModItem
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
            if(player.altFunctionUse == 2)
            {
                player.Teleport(Main.MouseWorld, 1);
                player.AddBuff(BuffID.ShadowDodge, 1);
            }

            
        }
        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

    }
}