using System;
namespace fangame
{
    public class CureSpell: Spell
    {
        public static int INITIAIL_MIN_MANA = 20;
        public CureSpell(Mag owner, bool isVerbal, bool isMoveable) : base(isVerbal, isMoveable, owner, INITIAIL_MIN_MANA)
        {
        }

        public bool cure(Player player, HealthState healthState)
        {
            if (owner.Mana < 20)
            {
                throw new Exception("Mana is not enough !!!");
            }
            base.performSpell(player, (int)healthState);
            this.owner.Mana = (uint)((int)this.owner.Mana - INITIAIL_MIN_MANA);
            return true;
        }

        public override bool spell(Player player, int strenght)
        {
            if (player.healthState == HealthState.Sick) {
                player.healthState = (HealthState)strenght;
                return true;
            }
            throw new Exception("Не хватает маны!!!");
        }

    }
}
