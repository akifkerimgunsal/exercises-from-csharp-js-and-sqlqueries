using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ornek2
{
    internal class Motorcycle : Vehicle
    {
        public string Type { get; set; }
       
        public Motorcycle(string brand, int year, string type) : base(brand, year)
        {
            Type = type;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Araç Türü: Motorsiklet, Marka: {Brand}, Yıl: {Year}, Tür: {Type}");
        }
    }
}
