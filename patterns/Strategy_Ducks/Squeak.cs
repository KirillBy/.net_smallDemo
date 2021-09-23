using System;

namespace Strategy_Ducks
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}