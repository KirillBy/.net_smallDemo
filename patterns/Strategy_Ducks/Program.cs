using System;
using System.ComponentModel.DataAnnotations;

namespace Strategy_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks = new Duck[] {new ModelDuck(), new WoodDuck(), new WoodDuck(new FlyWithWings(), new Squeak())};
            foreach (var duck in ducks)
            {
                duck.swim();
                duck.fly();
                duck.quack();
            }
        }
    }
}
