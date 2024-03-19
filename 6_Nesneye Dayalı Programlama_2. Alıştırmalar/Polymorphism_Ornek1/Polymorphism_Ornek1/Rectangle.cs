using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ornek1
{
    internal class Rectangle : Shape
    {
        
        public Rectangle() : base(0, 0)
        {
        }

        
        public Rectangle(int width, int height) : base(width, height)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Dikdörtgen çizildi: Genişlik = {width}, Yükseklik = {height}");
        }
    }
}
