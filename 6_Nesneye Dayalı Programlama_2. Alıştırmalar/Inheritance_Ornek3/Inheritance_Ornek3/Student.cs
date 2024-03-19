using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek3
{
    internal class Student : Person
    {
        public void Answer()
        {
            Console.WriteLine("Öğrenci soruya cevap veriyor.");
        }
    }
}
