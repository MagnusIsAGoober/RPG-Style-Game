using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MyRPG
{
    public class Player
    {

        public int Health { get; set; }

        public String Name { get; set; }

        public bool IsDead { get; set; }

        public bool IsGuarding { get; set; }

        public Player()
        {
            Health = 100;
        }



        //this gets called when the player is hit
        //hit value is the amount of damage an player will take
        public void GetsHit(int hit_value)
        {
            Health = Health - hit_value;

            Console.WriteLine(Name + " was hit for " + hit_value + " damage! You now have" + Health + " remaining." + Environment.NewLine);
            


            if (Health <= 0)
            {
                Die();
            }

        }

        public void Heal(int amount_to_heal)
        {
            Health = (Health + amount_to_heal > 100) ? 100 : (Health + amount_to_heal);

            Console.WriteLine(Name + " was healed for " + amount_to_heal + " Health! You now have" + Health + " remaining.");
        }

        public void Die()
        {
            IsDead = true;
        }
    }
}
