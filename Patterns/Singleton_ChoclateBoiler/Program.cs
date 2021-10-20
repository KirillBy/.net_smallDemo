using System;

namespace Singleton_ChoclateBoiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var boiler1 = ChocolateBoiler.getChocolateBoiler();
            Console.WriteLine(boiler1.IsBoiled);
            boiler1.boil();
            var boiler2 = ChocolateBoiler.getChocolateBoiler();
            Console.WriteLine(boiler1.IsBoiled);
            Console.WriteLine(boiler2.IsBoiled);
            Console.WriteLine(Object.ReferenceEquals(boiler1, boiler2));
        }
    }
}
