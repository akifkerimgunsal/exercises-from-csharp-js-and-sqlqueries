namespace GenericType_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair<int> intPair = new Pair<int>(3, 5);
            Console.WriteLine("İnteger Çift: " + intPair);

            Pair<string> stringPair = new Pair<string>("Hello", "World");
            Console.WriteLine("String Çift: " + stringPair);
        }
    }
}
