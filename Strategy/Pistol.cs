using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Strategy_CSHARP.Strategy
{
    public class Pistol : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack from Pistol!");
        }
    }
}
