using System;
using System.Collections.Generic;

namespace Strategy_DucksBehaviour
{
    class Program
    {
        static void Main(string[] args)
        {
            var ducks = new List<Duck>() { new ElectronicDuck(), new SimpleDuck(), new WoodenDuck() };
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                duck.Fly();
                duck.Quack();
            }
        }
    }
}
