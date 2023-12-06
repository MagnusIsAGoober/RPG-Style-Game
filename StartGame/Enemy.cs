using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Enemy
    {

        public int Health { get; set; }

        public String Name { get; set; }

        public bool IsDead { get; set; }

        public int MaxAttackDMG { get; set; }

        public Enemy(string name)
        {
            Health = 100;

            Name = name;

            MaxAttackDMG = 10;
        }

        //this gets called when the enemy is hit
        //hit value is the amount of damage an enemy will take
        public void GetsHit (int hit_value)
        {
            Health = Health - hit_value; 

            Console.WriteLine(Name + " was hit for " + hit_value + " damage! And has " + Health + " remaining.");

            if (Health <= 0)
            {
                Console.WriteLine(Name + " was slain!");
                IsDead = true;
            }
        }
    }
}
