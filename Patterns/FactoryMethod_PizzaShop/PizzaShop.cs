using System;
using AbstractFactory_PizzaIngredients;

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
            Console.WriteLine(pizza.ToString());
            return pizza;
        }

        protected abstract Pizza createPizza(string type);
    }
    
    public class NYPizzaShop : PizzaShop
    {
        protected override Pizza createPizza(string type)
        {
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            switch (type)
            {
                case "cheese" : return new NYStyleCheesePizza(ingredientFactory);
                case "pepperoni" : return new NYStylePepperoniPizza(ingredientFactory);
                case "vegan" : return new NYStyleVeganPizza(ingredientFactory);
                default: throw new ArgumentException("Incorrect type of pizza");
            }
        }
    }
    
    
    public class ChicagoPizzaShop : PizzaShop
    {
        protected override Pizza createPizza(string type)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            switch (type)
            {
                case "cheese" : return new ChicagoStyleCheesePizza(ingredientFactory);
                case "pepperoni" : return new ChicagoStylePepperoniPizza(ingredientFactory);
                case "vegan" : return new ChicagoStyleVeganPizza(ingredientFactory);
                default: throw new ArgumentException("Incorrect type of pizza");
            }
        }
    }
}