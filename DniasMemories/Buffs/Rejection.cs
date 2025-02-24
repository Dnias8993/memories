using Terraria;
using Terraria.ModLoader;

namespace DniasMemories.Buffs
{

    public class Rejection : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoTimeDisplay[Type] = true; // True, the time left won't be displayed
            Main.buffNoSave[Type] = false; // This buff will persist after death and respawn
            Main.debuff[Type] = false; // It's a debuff, so it should be marked as such
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.statManaMax2 > 0) // Ensure max mana is greater than zero to avoid negative values
            {
                player.statManaMax2 *= 0;
                player.statManaMax *= 0;
                player.lifeRegen += 3;
                player.GetArmorPenetration(DamageClass.Generic) += 10;
                player.GetDamage(DamageClass.Magic) *= 0f;
                player.GetDamage(DamageClass.Summon) *= 0f;

            }
        }
}

}
