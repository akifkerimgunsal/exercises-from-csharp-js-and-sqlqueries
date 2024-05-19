using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek2
{
    internal class Bicycle : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Bisiklet pedallanarak ilerliyor.");
        }

        public void RingBell()
        {
            Console.WriteLine("Bisiklet çan çalıyor.");
        }
    }
}
