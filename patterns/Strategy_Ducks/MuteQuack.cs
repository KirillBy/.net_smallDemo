using System;

namespace Strategy_Ducks
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}