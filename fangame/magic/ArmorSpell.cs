using System;
namespace fangame
{
    public class ArmorSpell : Spell
    {
        public static int INITIAIL_MIN_MANA = 50;
        public ArmorSpell(Mag owner, bool isVerbal, bool isMoveable) : base(isVerbal, isMoveable, owner, INITIAIL_MIN_MANA)
        {
        }

        public bool cure(Player player, HealthState healthState)
        {
            base.performSpell(player, (int)healthState);
            return true;
        }

        public override bool spell(Player player, int strenght)
        {

            player.unBreakableTime = strenght;
            player.healthState = HealthState.Unbreakable;
            this.owner.Mana = (uint)((int)this.owner.Mana - (strenght * INITIAIL_MIN_MANA));
            return false;

        }
        public bool doUnBreakabe(Player player, int strenght)
        {
            base.minMana = strenght * INITIAIL_MIN_MANA;
            bool result = base.performSpell(player, strenght);
            base.minMana = INITIAIL_MIN_MANA;
            return result;
        }

    }
}
