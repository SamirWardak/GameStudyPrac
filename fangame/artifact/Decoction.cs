using System;
namespace fangame
{
    public class Decoction: SpellArtifact
    {
        public Decoction(Player owner, int arttifactMana = 0) : base(false, owner, arttifactMana)
        {
        }

        public bool decoctionUse(Player player)
        {
            return this.performSpell(player);
        }

        public override bool use(Player player, int strenght)
        {
            if (player.healthState == HealthState.Normal || player.healthState == HealthState.Weakened) {
                player.ArtifactStatus = HealthState.Poisoned;
                player.healthState = HealthState.Normal;
                return true;
            }
            else
            {
                return false;
            }


        }
    }
}
