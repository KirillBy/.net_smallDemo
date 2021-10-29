using System;
using System.Globalization;

namespace TemplateMethod_TeaCoffee
{
    public abstract class HotSpiritBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
            AddSugar();
        }

        protected void BoilWater()
        {
            Console.WriteLine("Water is boiling");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring hot spirit into cup");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected virtual void AddSugar()
        {
            Console.WriteLine("Adding two spoons of sugar");
        }
    }
    
    public class Tea : HotSpiritBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override void AddSugar()
        {
            Console.WriteLine("No sugar in tea");
        }
    }
    
    public class Coffee : HotSpiritBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping coffee throw filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding milk");
        }
    }
}