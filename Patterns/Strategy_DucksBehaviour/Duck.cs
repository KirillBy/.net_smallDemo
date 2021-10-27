using System;

namespace Strategy_DucksBehaviour
{
    public abstract class Duck
    {
        protected IFlyBehaviour _flyBehaviour;
        protected IQuackBehaviour _quackBehaviour;

        public virtual void Swim()
        {
            Console.WriteLine("I'm swimming. All ducks can swim");
        }

        public virtual void Quack()
        {
            _quackBehaviour.Quack();
        }

        public virtual void Fly()
        {
            _flyBehaviour.Fly();
        }

        public abstract void Display();
    }
    
    public class SimpleDuck : Duck
    {
        public SimpleDuck()
        {
            this._flyBehaviour = new SimpleFly();
            this._quackBehaviour = new SimpleQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I'm simple duck");
        }
    }

    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            this._flyBehaviour = new NoFly();
            this._quackBehaviour = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm wooden Duck");
        }
    }

    public class ElectronicDuck : Duck
    {
        public ElectronicDuck()
        {
            this._flyBehaviour = new ReactiveFly();
            this._quackBehaviour = new SquickQuack();
        }
        
        public override void Display()
        {
            Console.WriteLine("I'm electronic Duck");
        }
    }
}