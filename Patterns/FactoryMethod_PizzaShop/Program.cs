using System;

namespace FactoryMethod_PizzaShop
{
    class Program
    {
        static void Main(string[] args)
        {
            ChicagoPizzaShop chicagoPizzaShop = new ChicagoPizzaShop();
            NYPizzaShop nyPizzaShop = new NYPizzaShop();
            chicagoPizzaShop.OrderPizza("cheese");
            chicagoPizzaShop.OrderPizza("pepperoni");
            chicagoPizzaShop.OrderPizza("vegan");
            nyPizzaShop.OrderPizza("cheese");
            nyPizzaShop.OrderPizza("pepperoni");
            nyPizzaShop.OrderPizza("vegan");
        }
    }
}
