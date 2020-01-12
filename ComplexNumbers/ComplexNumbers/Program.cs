using System;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(2,9);
            Complex c2 = new Complex(1,2);
            Complex result = c1.Plus(c2);
            Console.WriteLine($"{result.MaterialPart}.{result.FloatPart}");
            result = c1.Minus(c2);
            Console.WriteLine($"{result.MaterialPart}.{result.FloatPart}");
        }
    }
}
