using System.Drawing;

namespace Polymorphism_Ornek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parametre almayan constructor kullanımı
            Shape shape1 = new Shape();
            shape1.Draw(); 

            
            Shape shape2 = new Shape(10, 20);
            shape2.Draw(); 

            // Parametre almayan constructor kullanımı
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Draw(); 

            
            Rectangle rectangle2 = new Rectangle(5, 7);
            rectangle2.Draw(); 
        }
    }
}
