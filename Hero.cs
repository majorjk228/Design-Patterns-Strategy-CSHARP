using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Strategy_CSHARP.Strategy;

namespace Design_Patterns_Strategy_CSHARP
{
    public class Hero
    {
        private readonly string Name;
        private IWeapon? Weapon;

        public Hero(string name)
        {
            this.Name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            Weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine(">>>");

            if (Weapon == null)
            {
                Console.WriteLine($"{Name} cant attack! Set a weapon!");
                return;
            }

            Console.WriteLine($"{Name} stands!");

            Console.WriteLine($"{Name}");

            Weapon.Shoot();

            Console.WriteLine("Attack is done!");
        }
    }
}
