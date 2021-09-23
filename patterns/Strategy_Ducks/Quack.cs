using System;

namespace Strategy_Ducks
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}