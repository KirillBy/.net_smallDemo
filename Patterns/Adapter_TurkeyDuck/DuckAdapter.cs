using System;
using Strategy_DucksBehaviour;

namespace Adapter_TurkeyDuck
{
    public class TurkeyAdapter : Duck
    {
        private readonly ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            _turkey = turkey;
        }
        public override void Display()
        {
            Console.WriteLine("I'm not duck");
        }

        public override void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();   
            }
        }

        public override void Swim()
        {
            Console.WriteLine("Turkeys can't swim");
        }

        public override void Quack()
        {
            _turkey.Gobble();
        }
    }
}