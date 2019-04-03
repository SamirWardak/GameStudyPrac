using System;
namespace fangame
{
    public class LightningStaff: SpellArtifact
    {

        public LightningStaff(Player owner, int arttifactMana) : base(false, owner, arttifactMana)
        {
        }

        public bool bump(Player player, int strenght)
        {
            return this.performSpell(player, strenght);
        }

        public override bool use(Player player, int strenght)
        {
            player.Health = strenght > player.Health ? 0 : (uint)((int)player.Health - strenght);
            return true;
        }
    }
}
