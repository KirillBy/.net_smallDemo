using System;
using System.Collections.Generic;
using AbstractFactory_PizzaIngredients;

namespace FactoryMethod_PizzaShop
{
    public abstract class Pizza
    {
        protected String _name;
        protected IDough _dough;
        protected ISauce _sauce;
        protected ICheese _cheese;
        protected IPepperoni _pepperoni;
        protected IClams _clams;
        protected IVeggies[] _veggies;
        protected IPizzaIngredientFactory _ingredientFactory;

        public Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        
        public virtual void Prepare()
        {
            Console.WriteLine("Preparing: " + _name);
            _dough = _ingredientFactory.CreateDough();
            _sauce = _ingredientFactory.CreateSauce();
            _cheese = _ingredientFactory.CreateCheese();
            _clams = _ingredientFactory.CreateClam();
            _pepperoni = _ingredientFactory.CreatePepperoni();
            _veggies = _ingredientFactory.CreateVeggies();
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

        public override string ToString()
        {
            return "Pizza " + _name + " .Ingredients: " + _cheese.Name + ", " + _dough.Name + ", " +
                   _sauce.Name + ", " + _pepperoni.Name + ", " + _clams.Name + ", ";
        }
    }
}