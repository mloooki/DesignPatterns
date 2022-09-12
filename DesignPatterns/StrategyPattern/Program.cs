using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is starting ");

            Duck duck = new Duck(new SimpleFlyStrategy(), new GeographicDisplayStrategy());
            Console.WriteLine(duck.InvokeFly());
            Console.WriteLine(duck.InvokeDisplay());

            duck.SetFlyStrategy(new ComplexFlyStrategy());
            duck.SetDisplayStrategy(new TextDisplayStrategy());

            Console.WriteLine(duck.InvokeFly());
            Console.WriteLine(duck.InvokeDisplay());
        }
    }
}
