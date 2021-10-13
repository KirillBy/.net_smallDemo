using System;

namespace Decorator_Starbuzz
{
    public class Milk : BeverageDecorator
    {
        private Beverage _beverage;
        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return  _beverage.GetDescription() + " with Milk";
        }
        
        public override void SetSize(Size size)
        {
            _beverage.SetSize(size);
        }

        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return _beverage.Cost() + 0.3;
                case Size.Medium: return _beverage.Cost() + 0.4;
                case Size.Big: return _beverage.Cost() + 0.45;
                default: return _beverage.Cost() + 0.4;
            }
        }
    }
    
    public class Soy : BeverageDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        
        public override void SetSize(Size size)
        {
            _beverage.SetSize(size);
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with Soy";
        }

        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return _beverage.Cost() + 0.25;
                case Size.Medium: return _beverage.Cost() + 0.3;
                case Size.Big: return _beverage.Cost() + 0.35;
                default: return _beverage.Cost() + 0.3;
            }
        }
    }
    
    public class Whip : BeverageDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override void SetSize(Size size)
        {
            _beverage.SetSize(size);
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + " with Whip";
        }

        public override double Cost()
        {
            switch (_size)
            {
                case Size.Small: return _beverage.Cost() + 0.25;
                case Size.Medium: return _beverage.Cost() + 0.35;
                case Size.Big: return _beverage.Cost() + 0.45;
                default: return _beverage.Cost() + 0.35;
            }
        }
    }
}