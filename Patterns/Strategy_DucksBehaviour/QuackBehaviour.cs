using System;

namespace Strategy_DucksBehaviour
{
    public interface IQuackBehaviour
    {
        public void Quack();
    }
    
    public class SimpleQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Quack-Quack-Quack");
        }
    }
    
    public class SquickQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("Squick-Squick-Squick");
        }
    }

    public class MuteQuack : IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("--Silence--");
        }
    }
}