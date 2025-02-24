using Terraria;
using Terraria.ModLoader;

namespace DniasMemories.Buffs
{
    public class Hemorage : ModBuff
    {
        public override void SetStaticDefaults()
        {
            
            Main.debuff[Type] = true; // Add this line to mark the buff as a debuff
            Main.pvpBuff[Type] = true; // Allows the debuff to be inflicted in PvP
            Main.buffNoSave[Type] = false; // The debuff will persist when you die
        }

        public override void Update(Player player, ref int buffIndex)
        {
            float lifeDrain = 0.01f; // Drain rate (1% of max life per second)
            player.lifeRegen -= (int)(player.statLifeMax2 * lifeDrain); // Reduce normal life regeneration
            
            
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            float lifeDrain = 0.02f; // Drain rate (1% of max life per second=.01)
            npc.lifeRegen -= (int)(npc.lifeMax * lifeDrain); // Reduce normal life regeneration           
        }
    }

}
