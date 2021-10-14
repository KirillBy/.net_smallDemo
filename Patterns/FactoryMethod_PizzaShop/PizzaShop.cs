using System;
using System.Net;

namespace FactoryMethod_PizzaShop
{
    public abstract class PizzaShop
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }
    
    public class NYPizzaShop : PizzaShop
    {
        protected override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese" : return new NYStyleCheesePizza();
                case "pepperoni" : return new NYStylePepperoniPizza();
                case "vegan" : return new NYStyleVeganPizza();
                default: throw new ArgumentException("Incorrect type of pizza");
            }
        }
    }
    
    
    public class ChicagoPizzaShop : PizzaShop
    {
        protected override Pizza createPizza(string type)
        {
            switch (type)
            {
                case "cheese" : return new ChicagoStyleCheesePizza();
                case "pepperoni" : return new ChicagoStylePepperoniPizza();
                case "vegan" : return new ChicagoStyleVeganPizza();
                default: throw new ArgumentException("Incorrect type of pizza");
            }
        }
    }
}