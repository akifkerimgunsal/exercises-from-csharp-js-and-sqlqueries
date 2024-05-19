using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ornek1
{
    internal class Shape
    {
        protected int width;
        protected int height;

        
        public Shape()
        {
            width = 0;
            height = 0;
        }

        
        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual void Draw()
        {
            Console.WriteLine($"Şekil çizildi: Genişlik = {width}, Yükseklik = {height}");
        }
    }
}
