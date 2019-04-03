using System;
using System.Collections.Generic;
namespace fangame
{
    public class Player : IComparable<Player>
    {
        public static int count = 1;
        public int id { get; }
        public string name { get; }
        public HealthState ArtifactStatus = HealthState.Normal;
        public HealthState healthState { get; set; }
       
        public HealthState artHealtch { get; set; }
        public uint maxHealth = 100;
        private uint health;
        public uint Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value; //value <= maxHealth ? value : maxHealth;
                this.healthState = getHealthState();
            }
        }
        public Race race { get; }
        public Sex sex { get; }
        public bool speak { get; set; }
        public bool move { get; set; }
        public uint age { get; set; }
        public ulong experience { get; set; }
        public int unBreakableTime { get; set;}

        public Player(string name, Race race, Sex sex) {
            this.id = count;
            this.name = name;
            this.race = race;
            this.sex = sex;
        }

        public Player(string name, HealthState healthState, bool speak, bool move, Race race, Sex sex, uint age, ulong experience, uint health)
        {
            count++;
            id = count;
            this.name = name;
            this.healthState = healthState;
            this.speak = speak;
            this.move = move;
            this.race = race;
            this.sex = sex;
            this.age = age;
            this.experience = experience;
            this.health = health;
        }

        public int CompareTo(Player otherPlayer)
        {
            return this.experience < otherPlayer.experience ? 1 :
                   this.experience > otherPlayer.experience ? -1 : 0;
        }


        private HealthState getHealthState()
        {
            int healthPercent = (int)this.health * 100 /(int)this.maxHealth;
            switch (healthPercent)
            {
                case int n when (n >= 10):
                    {
                        if (artHealtch == 0)
                        {
                            return HealthState.Normal;
                        }
                        else
                        {
                            return artHealtch;
                        }

                    }



                case int n when (0 < n && n < 10):
                    if (artHealtch == 0)
                    {
                        return HealthState.Weakened; 
                    }
                    else
                    {
                        return artHealtch;
                    }

            }
            return HealthState.Dead;
        }

        public override string ToString() {
            return "id: " + id + " name: " + name + " health: " + health + " speak: " + speak +
                    " move: " + move + " race: " + race + " sex: "+ sex + " age: " + age + " experience: " + experience +
                " health state: " + getHealthState();
        }


    }
}
