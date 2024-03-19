using System;

namespace EncapsulationOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();            
            person.Name = "John";
            
            Console.WriteLine("Kişinin adı: " + person.Name);           
            person.Name = ""; 
        }
    }
}
