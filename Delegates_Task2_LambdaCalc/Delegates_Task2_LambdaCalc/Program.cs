using System;

namespace Delegates_Task2_LambdaCalc
{
    class Program
    {
        public delegate double Calculate(int a, int b);
        static void Main(string[] args)
        {
            Calculate plus = new Calculate((a, b) => a + b);
            Calculate minus = new Calculate((a, b) => a - b);
            Calculate multiplu = new Calculate((a, b) => a * b);
            Calculate divide = new Calculate((a, b) =>  (double)a / (double)b);

            Console.WriteLine(plus.Invoke(2, 3));
            Console.WriteLine(minus.Invoke(2, 3));
            Console.WriteLine(multiplu.Invoke(2, 3));
            Console.WriteLine(divide.Invoke(2, 3));

        }

        private static double MathRound(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
