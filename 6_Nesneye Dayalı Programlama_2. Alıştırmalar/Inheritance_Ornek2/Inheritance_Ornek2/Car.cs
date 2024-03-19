using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek2
{
    internal class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Araba yola çıkıyor.");
        }

        public void Accelerate()
        {
            Console.WriteLine("Araba hızlanıyor.");
        }
    }
}
