using System;
namespace fangame
{
    public class BasiliskEye : SpellArtifact
    {
        public BasiliskEye(Player owner, int arttifactMana = 0) : base(false, owner, arttifactMana)
        {
        }

        public bool eyeUse(Player player)
        {
            return this.performSpell(player);
        }

        public override bool use(Player player, int strenght)
        {
            if (player.healthState != HealthState.Dead)
            {
                player.ArtifactStatus = HealthState.Paralyzed;
                player.healthState = HealthState.Paralyzed;
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}

