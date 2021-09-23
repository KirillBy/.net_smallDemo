using System;

namespace Strategy_Ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public void fly()
        {
            _flyBehavior.fly();
        }

        public void quack()
        {
            _quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All duck swimming the same way");
        }
    }
}