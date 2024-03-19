using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Ornek3
{
    internal class Teacher : Person
    {
        public void Teach()
        {
            Console.WriteLine("Öğretmen ders anlatıyor.");
        }
    }
}
