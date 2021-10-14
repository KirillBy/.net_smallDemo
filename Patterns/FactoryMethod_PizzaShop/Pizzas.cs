using System;

namespace FactoryMethod_PizzaShop
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            _name = "NY style cheese pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";
            _toppings.Add("Grated Reggiano Cheese");
        }
    }
    
    public class NYStylePepperoniPizza : Pizza
    {
        public NYStylePepperoniPizza()
        {
            _name = "NY style pepperoni pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";
            _toppings.Add("Sliced Pepperoni");
        }
    }
    
    public class NYStyleVeganPizza : Pizza
    {
        public NYStyleVeganPizza()
        {
            _name = "NY style vegan pizza";
            _dough = "Thin Crust Dough";
            _sauce = "Marinara Sauce";
            _toppings.Add("A lot of vegetables");
        }
    }
    
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            _name = "Chicago style cheese pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("Mozzarella Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    
    public class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            _name = "Chicago style pepperoni pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("Sliced Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
    
    public class ChicagoStyleVeganPizza : Pizza
    {
        public ChicagoStyleVeganPizza()
        {
            _name = "Chicago style vegan pizza";
            _dough = "Extra Thick Crust Dough";
            _sauce = "Plum Tomato Sauce";
            _toppings.Add("A lot of vegetables");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}