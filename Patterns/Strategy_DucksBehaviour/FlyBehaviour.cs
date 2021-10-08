using System;

namespace Strategy_DucksBehaviour
{
    public interface IFlyBehaviour
    {
        public void Fly();
    }

    public class SimpleFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm just flying");
        }
    }
    
    public class NoFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
    
    public class ReactiveFly : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying like a helicopter");
        }
    }
}