

namespace ReflectionSample
{
    class Motorcycle
    {
        public string Name { get; private set; }
        public  string Model { get; private set; }
        private int _vinNumber = 111;
        public int Odometer { get; private set; }
        
        public int GetVinNumber()
        { return _vinNumber; }

        public override string ToString()
        {
            return $"Motorcycle: {Name}, Model {Model}, VinNumber: {GetVinNumber()}";
        }
    }
}
