using System;
namespace fangame
{
    public class Mag : Player
    {
        public uint maxMana = 100;
        private uint mana;
        public uint Mana
        {
            get
            {
                return mana;
            }
            set
            {
                mana = value <= this.maxMana ? value : maxMana;
            }
        }

        public Mag(string name, Race race, Sex sex) : base(name, race, sex)
        {
        }

        public Mag(string name, HealthState healthState, bool speak,
        bool move, Race race, Sex sex, uint age, ulong experience, uint health, uint mana) : base(name,
            healthState, speak, move, race, sex, age, experience, health)
        {
            this.mana = mana;
        }

        public override string ToString() {
            return "id: " + id + " name: " + name + " health: " + Health + " mana: " + Mana + " speak: " + speak +
                   " move: " + move + " race: " + race + " sex: " + sex + " age: " + age + " experience: " + experience +
               " health state: " + healthState;
        }
    }
}
