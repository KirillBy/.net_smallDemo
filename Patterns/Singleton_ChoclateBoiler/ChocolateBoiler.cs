namespace Singleton_ChoclateBoiler
{
    public class ChocolateBoiler
    {
        public bool IsEmpty { get; private set; }
        public bool IsBoiled { get; private set; }
        private static ChocolateBoiler _boiler;
        static object locker = new object();

        private ChocolateBoiler()
        {
            IsBoiled = false;
            IsEmpty = false;
        }

        public static ChocolateBoiler getChocolateBoiler()
        {
            lock (locker)
            {
                if (_boiler == null)
                    _boiler = new ChocolateBoiler();   
            }

            return _boiler;
        }

        public void fill()
        {
            if (IsBoiled)
            {
                IsEmpty = false;
                IsBoiled = false;
            }
        }

        public void boil()
        {
            if (!IsEmpty && !IsBoiled)
                IsBoiled = true;
        }

        public void drain()
        {
            if (!IsEmpty && IsBoiled)
                IsEmpty = true;
        }
    }
}