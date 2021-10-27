using System;

namespace Adapter_TurkeyDuck
{
    public interface ITurkey
    {
        public void Gobble();
        public void Fly();
    }
    
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }

        public void Fly()
        {
            Console.WriteLine("I'm flying on a short distance");
        }
    }
}