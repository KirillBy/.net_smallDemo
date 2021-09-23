using System;

namespace Strategy_Ducks
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}