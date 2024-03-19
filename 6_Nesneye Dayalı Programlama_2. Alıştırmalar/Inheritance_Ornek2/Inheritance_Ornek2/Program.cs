namespace Inheritance_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move(); // overriding ediliyor
            car.Accelerate(); 

            Bicycle bicycle = new Bicycle();
            bicycle.Move(); // overriding ediliyor
            bicycle.RingBell(); 
        }
    }
}
