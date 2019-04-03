using System;

namespace fangame
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Player test = new Player("Test", Race.Person, Sex.male);
            test.age = 21;
            test.Health = 400;
            test.maxHealth = 300;
            test.experience = 100;
            test.healthState = HealthState.Normal;
            Mag mag = new Mag("Test", Race.Person, Sex.male);
            mag.Mana = 100;
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");





            
            AddHealthSpell addHealth = new AddHealthSpell(mag, true, true);
            addHealth.addHealthByMana(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");


            test.healthState = HealthState.Sick;
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");

            mag.Mana = 250;
            CureSpell cure = new CureSpell(mag, true, true);
            cure.cure(test, HealthState.Normal);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");





            LivingWater livingWater = new LivingWater(mag, Water.Big);
            livingWater.drink(test);
            livingWater.drink(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");

            /*
            LightningStaff lightningStaff = new LightningStaff(mag, 400);
            lightningStaff.bump(test, 500);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");
            */
            DeadWater deadWater = new DeadWater(mag, Water.Big);
            deadWater.drink(mag);
            Console.WriteLine(mag.ToString());
            Console.WriteLine("++++++++++++++++++++++");

            deadWater = new DeadWater(mag, Water.Big);
            deadWater.drink(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");


            test.healthState = HealthState.Normal;
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");

            Decoction decoction = new Decoction(mag);
            decoction.decoctionUse(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");

            PoisonousSaliva poisonousSaliva = new PoisonousSaliva(mag, 150);
            poisonousSaliva.bump(test, 100);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");


            BasiliskEye basiliskEye = new BasiliskEye(mag);
            basiliskEye.eyeUse(test);
            Console.WriteLine(test.ToString());
            Console.WriteLine("++++++++++++++++++++++");


            Console.ReadKey();

        }
    }
}
