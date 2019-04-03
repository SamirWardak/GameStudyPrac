using System;
namespace fangame
{
    public class AddHealthSpell: Spell
    {
        public static int INITIAIL_MIN_MANA = 0;
        public AddHealthSpell(Mag owner,bool isVerbal, bool isMoveable):base(isVerbal, isMoveable, owner, INITIAIL_MIN_MANA)
        {
        }

        public bool addHealthByMana(Player player) {
            if (owner.Mana < 2) {
                throw new Exception("Mana is not enough !!!");
            }
            int point = (int)owner.Mana / 2;
            return addHealthToPoint(player, point);
        }

        public override bool spell(Player player, int strenght)
        {
            player.Health =  (uint)((int)player.Health + (int)strenght);
            this.owner.Mana = (uint)((int)this.owner.Mana - (strenght * INITIAIL_MIN_MANA));
            return true;
        }

        public bool addHealthToPoint(Player player, int point) {
            base.minMana = point * 2;
            bool result = base.performSpell(player, point);
            base.minMana = INITIAIL_MIN_MANA;
            return result;
        }

    }
}
