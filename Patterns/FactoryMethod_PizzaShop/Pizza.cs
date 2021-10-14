using System;
using System.Collections.Generic;

namespace FactoryMethod_PizzaShop
{
    public abstract class Pizza
    {
        protected string _name;
        protected string _dough;
        protected string _sauce;
        protected List<string> _toppings = new List<string>();

        public virtual void Prepare()
        {
          Console.WriteLine("Preparing " + _name);   
          Console.WriteLine("Tossing dough " + _dough);   
          Console.WriteLine("Adding sauce " + _sauce);   
          Console.WriteLine("Adding toppings ");
          foreach (var topping in _toppings)
          {
              Console.WriteLine(topping + " ");
          }
        }
        
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350 degrees");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza into special box");
        }

        public string GetName()
        {
            return _name;
        }
    }
}