using System;

namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is starting!");

            AnimalFactory factory = new AnimalFactory();

            var animal1 = factory.CreateAnimal("");
            var animal2 = factory.CreateAnimal("T");
            var animal3 = factory.CreateAnimal("This is a test for the third type");

            Console.WriteLine(animal1.GetAllInfo());
            Console.WriteLine(animal2.GetAllInfo());
            Console.WriteLine(animal3.GetAllInfo());
        }
    }
}
