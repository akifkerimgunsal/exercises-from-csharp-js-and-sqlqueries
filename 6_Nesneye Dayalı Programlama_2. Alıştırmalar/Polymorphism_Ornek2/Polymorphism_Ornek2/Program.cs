namespace Polymorphism_Ornek2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[3];
            vehicles[0] = new Car("Fiat", 2020, 5);
            vehicles[1] = new Motorcycle("Suzuki", 2015, "Günlük");
            vehicles[2] = new Car("Kia", 2010, 4);

            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }
        }
    }
}
