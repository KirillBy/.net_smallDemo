namespace Decorator_Starbuzz
{
    public enum Size {
        Small,
        Medium,
        Big
    }
    public abstract class Beverage
    {
        protected string _desription;
        protected Size _size = Size.Medium;

        public virtual void SetSize(Size size)
        {
            _size = size;
        }
        
        public virtual string GetDescription()
        {
            return _size.ToString() + " " + _desription;
        }

        public abstract double Cost();
    }
}