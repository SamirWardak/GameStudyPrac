using System;
namespace fangame
{
    public abstract class SpellArtifact : Magic
    {
        public int artifactMana = 0;
        public bool renewability = false;
        private bool used = false;

        public Player owner;


        public SpellArtifact(bool renewability, Player owner, int artifactMana = 0)
        {
            this.artifactMana = artifactMana;
            this.owner = owner;
            this.renewability = renewability;
        }

        public abstract bool use(Player player, int strenght = 0);

       

        public bool performSpell(Player player = null, int strenght = 0)
        {
            if (!this.used || (this.renewability && this.artifactMana > 0 && artifactMana >= strenght))
            {
                bool res =  this.use(player, strenght);
                if (res)
                {
                    this.artifactMana -= strenght;
                    this.used = true;
                    return true;
                }
            }
            return false;
        }
    }
}
