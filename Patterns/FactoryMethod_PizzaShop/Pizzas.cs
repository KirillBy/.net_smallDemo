using System;
using AbstractFactory_PizzaIngredients;

namespace FactoryMethod_PizzaShop
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory)
        {
            _name = "NYStyle Cheese Pizza";
        }
    }
    
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory): base(ingredientFactory)
        {
            _name = "NYStyle Pepperoni Pizza";
        }
    }
    
    public class NYStyleVeganPizza : Pizza
    {
        public NYStyleVeganPizza(IPizzaIngredientFactory ingredientFactory): base(ingredientFactory)
        {
            _name = "NYStyle Vegan Pizza";
        }
    }
    
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory): base(ingredientFactory)
        {
            _name = "Chicago style cheese pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza(IPizzaIngredientFactory ingredientFactory): base(ingredientFactory)
        {
            _name = "Chicago style pepperoni pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    
    public class ChicagoStyleVeganPizza : Pizza
    {
        public ChicagoStyleVeganPizza(IPizzaIngredientFactory ingredientFactory): base(ingredientFactory)
        {
            _name = "Chicago style vegan pizza";
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}