using System;
namespace fangame
{
    public class PoisonousSaliva : SpellArtifact
    {

        public PoisonousSaliva(Player owner, int arttifactMana) : base(false, owner, arttifactMana)
        {
        }

        public bool bump(Player player, int strenght)
        {
            return this.performSpell(player, strenght);
        }

        public override bool use(Player player, int strenght)
        {
            if (strenght > player.Health)
            {
                player.Health = 0;
            }
            else
            {
                if (player.healthState == HealthState.Normal || player.healthState == HealthState.Weakened)
                {

                    player.ArtifactStatus = HealthState.Poisoned;
                    player.healthState = HealthState.Poisoned;
                    player.Health = (uint)((int)player.Health - strenght);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
