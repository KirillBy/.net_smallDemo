namespace Decorator_Starbuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _desription = "House Blend";
        }
        
        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return 0.6;
                case Size.Medium: return 0.8;
                case Size.Big: return 0.9;
                default: return 0.8;
            }
        }
    }
    
    
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _desription = "DarkRoast";
        }
        
        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return 0.7;
                case Size.Medium: return 0.75;
                case Size.Big: return 0.8;
                default: return 0.75;
            }
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            _desription = "Espresso";
        }

        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return 0.5;
                case Size.Medium: return 0.6;
                case Size.Big: return 0.7;
                default: return 0.6;
            }
        }
    }
}