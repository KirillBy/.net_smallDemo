using System;
using TriangleSquareReload;
namespace TriangleSquareReload
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("square with three sides is");
            Console.WriteLine($"{TriangleSquare.CalculateSquare(2, 3, 4)}");
            Console.WriteLine("square with hight and base is");
            Console.WriteLine($"{TriangleSquare.CalculateSquare(4, 5)}");
            Console.WriteLine("square with two sides and angle");
            Console.WriteLine($"{TriangleSquare.CalculateSquare(4, 5, 60)}");
        }
    }
}
