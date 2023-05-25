using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Strategy_CSHARP.Strategy
{
    public class WaterGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attack from WaterGun!");
        }
    }
}
