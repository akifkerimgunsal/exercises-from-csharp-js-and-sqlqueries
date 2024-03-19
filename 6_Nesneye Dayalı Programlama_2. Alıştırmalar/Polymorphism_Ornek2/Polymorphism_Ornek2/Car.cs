using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ornek2
{
    internal class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        
        public Car(string brand, int year, int numberOfDoors) : base(brand, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Araç Türü: Otomobil, Marka: {Brand}, Yıl: {Year}, Kapı Sayısı: {NumberOfDoors}");
        }
    }
}
