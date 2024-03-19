using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationOrnek
{
    internal class Person
    {
        private string name;
                
        public string Name
        {            
            get
            {
                return name;
            }            
            set
            {
                if (value != null && value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz isim.");
                }
            }
        }
    }
}
