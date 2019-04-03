using System;
namespace fangame
{
    public class UnParalyzedSpell : Spell
    {
        public static int INITIAIL_MIN_MANA = 85;
        public UnParalyzedSpell(Mag owner, bool isVerbal, bool isMoveable) : base(isVerbal, isMoveable, owner, INITIAIL_MIN_MANA)
        {
        }

        public bool revive(Player player, HealthState healthState)
        {
            base.performSpell(player, (int)healthState);
            this.owner.Mana = (uint)((int)this.owner.Mana - INITIAIL_MIN_MANA);
            return true;
        }

        public override bool spell(Player player, int strenght)
        {
            if (player.healthState == HealthState.Paralyzed)
            {
                player.Health = 1;
                player.healthState = (HealthState)strenght;
                return true;
            }
            return false;

        }

    }
}

