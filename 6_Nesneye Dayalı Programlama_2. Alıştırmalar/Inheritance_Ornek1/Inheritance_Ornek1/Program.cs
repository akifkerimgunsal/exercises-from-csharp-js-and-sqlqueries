namespace Inheritance_Ornek1;

internal class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();

        dog.Eat(); 
        dog.Bark(); 
        
        cat.Eat(); 
        cat.Meow(); 
    }
}

