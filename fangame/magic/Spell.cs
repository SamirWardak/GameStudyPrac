using System;
namespace fangame
{
    public abstract class Spell : Magic
    {
        public int minMana = 0;
        // verbals enum
        public bool isVerbal = false;
        // move enum
        public bool isMoveable = false;

        public Mag owner;


        public Spell(bool isVerbal, bool isMoveable, Mag owner, int minMana)
        {
            this.owner = owner;
            this.minMana = minMana;
            this.isVerbal = isVerbal;
            this.isMoveable = isMoveable;
        }

        public abstract bool spell(Player player, int strenght);

        public  bool performSpell(Player player = null, int strenght = 0) {
            if (this.owner.Mana >= minMana){
                this.spell(player, strenght);

                return true; 
            }
            return false;
        }
    }
}
