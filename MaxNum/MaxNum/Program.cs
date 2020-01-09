using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number ");
            double firstNum = double.Parse(Console.ReadLine());            
            Console.WriteLine("Enter second number ");
            double secondNum = double.Parse(Console.ReadLine());
            double maxNum = firstNum >= secondNum ? firstNum : secondNum;
            Console.WriteLine($"Max number is {maxNum}");
        }
    }
}
