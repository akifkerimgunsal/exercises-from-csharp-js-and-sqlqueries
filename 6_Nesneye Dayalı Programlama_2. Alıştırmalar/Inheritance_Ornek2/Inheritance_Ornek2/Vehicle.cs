using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek2
{
    internal class Vehicle
    {
        public virtual void Move()
        {
            Console.WriteLine("Araç hareket ediyor.");
        }
    }
}
