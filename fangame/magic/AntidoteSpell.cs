using System;
namespace fangame
{
    public class AntidoteSpell : Spell
    {
        public static int INITIAIL_MIN_MANA = 30;
        public AntidoteSpell(Mag owner, bool isVerbal, bool isMoveable) : base(isVerbal, isMoveable, owner, INITIAIL_MIN_MANA)
        {
        }

        public bool revive(Player player, HealthState healthState)
        {
            this.owner.Mana = (uint)((int)this.owner.Mana - INITIAIL_MIN_MANA);
            base.performSpell(player, (int)healthState);
            return true;
        }

        public override bool spell(Player player, int strenght)
        {
            if (player.healthState == HealthState.Poisoned)
            {
                player.healthState = (HealthState)strenght;
                return true;
            }
            return false;

        }

    }
}
