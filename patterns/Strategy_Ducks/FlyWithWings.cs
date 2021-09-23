using System;

namespace Strategy_Ducks
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}