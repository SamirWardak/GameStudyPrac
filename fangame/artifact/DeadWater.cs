using System;
namespace fangame
{
    public class DeadWater : SpellArtifact
    {
        Water water;
        public DeadWater(Player owner, Water water) : base(false, owner)
        {
            this.water = water;
        }

        public bool drink(Player player)
        {
            return this.performSpell(player);
        }

        public override bool use(Player player, int strenght)
        {
            if (player is Mag)
            {
                ((Mag)player).Mana = (uint)((int)((Mag)player).Mana + (int)this.water);
                return true;
            }
            return false;
        }


    }
}
