using System;

namespace Generic_Constrains_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection < Car > MyCars = new CarCollection<Car>();
            MyCars.Add(new Toyota("RAV4", 12344));
            MyCars.Add(new BMW("X7", 234431));
            MyCars.Add(new JAGUAR("X-TYPE", 32143));
            MyCars.Add(new BENTLEY("Continental", 34657));
            MyCars.Add(new GEELY("Atlas", 2352345));
            for (int i = 0; i < MyCars.Lenght; i++)
            {
                MyCars[i].ShowCar();
            }
            Console.WriteLine("Total numbers of cars in autopark {0}", MyCars.Lenght);
            MyCars.RemoveAllCars();
            for (int i = 0; i < MyCars.Lenght; i++)
            {
                MyCars[i].ShowCar();
            }
            Console.WriteLine("Total numbers of cars in autopark {0}", MyCars.Lenght);
        }
    }
}
