namespace AbstractFactory_PizzaIngredients
{
    public interface IDough
    {
        public string Name { get; set; }
    }
    
    public class ThinCrustDough : IDough
    {
        public string Name { get; set; } = "Thin Crust Dough";
    }
    
    public class ThickCrustDough : IDough
    {
        public string Name { get; set; } = "Thick Crust Dough";
    }

    public interface ISauce
    {
        public string Name { get; set; }
    }
    
    public class MarinaraSauce : ISauce
    {
        public string Name { get; set; } = "Marinara Sauce";
    }

    public class PlumTomatoSauce : ISauce
    {
        public string Name { get; set; } = "Plum Tomato Sauce";
    }

    public interface ICheese
    {
        public string Name { get; set; }
    }
    public class ReggianoCheese : ICheese
    {
        public string Name { get; set; } = "Reggiano Cheese";
    }

    public class MozzarellaCheese : ICheese
    {
        public string Name { get; set; } = "Mozzarella Cheese";
    }
    
    public interface IVeggies
    {
        public string Name { get; set; }
    }
    
    public class Garlic : IVeggies
    {
        public string Name { get; set; } = "Garlic";
    }
    
    public class Onion : IVeggies
    {
        public string Name { get; set; } = "Onion";
    }
    
    public class Mushroom : IVeggies
    {
        public string Name { get; set; } = "Mushroom";
    }
    
    public class RedPepper : IVeggies
    {
        public string Name { get; set; } = "Red Pepper";
    }
    
    public class Spinach : IVeggies
    {
        public string Name { get; set; } = "Spinach";
    }

    public class BlackOlives : IVeggies
    {
        public string Name { get; set; } = "Black Olives";
    }
    
    public class Eggplant : IVeggies
    {
        public string Name { get; set; } = "Eggplant";
    }

    public interface IClams
    {
        public string Name { get; set; }
    }
    
    public class FreshClams : IClams
    {
        public string Name { get; set; } = "Fresh Clams";
    }
    
    public class FrozenClams : IClams
    {
        public string Name { get; set; } = "Frozen Clams";
    }

    public interface IPepperoni
    {
        public string Name { get; set; }
    }
    
    public class SlicedPepperoni : IPepperoni
    {
        public string Name { get; set; } = "Sliced Pepperoni";
    }
}