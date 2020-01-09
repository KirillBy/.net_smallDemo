using System;

namespace TriangleGeron
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Please enter first line  of triangle: ");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Please enter second line  of triangle: ");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("Please enter third line  of triangle: ");
            double.TryParse(Console.ReadLine(), out c);

            double halfPer = (a + b + c) / 2;
            double square = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));

            Console.WriteLine($"Square of triangle is {square}");

        }
    }
}
