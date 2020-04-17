using System;

namespace Delegates_ExtraTask
{
    delegate double AverageDelegate(int a, int b, int c);
    class Program
    {
        private static AverageDelegate average = delegate (int a, int b, int c) { return (a + b + c) / 3; };

        static void Main(string[] args)
        {
           
            Console.WriteLine(average.Invoke(2, 4, 5) );
            Console.WriteLine("Hello World!");
        }
    }
}
