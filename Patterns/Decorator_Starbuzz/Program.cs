using System;

namespace Decorator_Starbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso = new Milk(espresso);
            espresso = new Milk(espresso);
            espresso = new Soy(espresso);
            Console.WriteLine(espresso.GetDescription());
            Console.WriteLine(espresso.Cost());
            espresso.SetSize(Size.Big);
            Console.WriteLine(espresso.GetDescription());
            Console.WriteLine(espresso.Cost());

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Whip(darkRoast);
            darkRoast = new Milk(darkRoast);
            Console.WriteLine(darkRoast.GetDescription());
            Console.WriteLine(darkRoast.Cost());
            darkRoast.SetSize(Size.Small);
            Console.WriteLine(darkRoast.GetDescription());
            Console.WriteLine(darkRoast.Cost());
        }
    }
}
