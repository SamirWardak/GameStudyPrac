using System;
namespace fangame
{
    public class LivingWater: SpellArtifact
    {
        Water water;
        public LivingWater(Player owner, Water water) : base(false, owner)
        {
            this.water = water;
        }

        public bool drink(Player player)
        {
            return this.performSpell(player);
        }

        public override bool use(Player player, int strenght)
        {
            player.Health = (uint)((int)player.Health + (int)this.water);
            return true;
        }

      
    }
}
