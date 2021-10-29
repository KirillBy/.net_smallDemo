using System;

namespace TemplateMethod_TeaCoffee
{
    class Program
    {
        static void Main(string[] args)
        {
            HotSpiritBeverage tea = new Tea();
            HotSpiritBeverage coffee = new Coffee();
            tea.PrepareRecipe();
            coffee.PrepareRecipe();
        }
    }
}
