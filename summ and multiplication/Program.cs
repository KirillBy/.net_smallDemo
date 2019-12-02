using System;

namespace summ_and_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, thirdNum;
            int sumNum, multiplNum;
            string enterNum;

            try
            {
                Console.WriteLine("Enter first number ->");
                enterNum = Console.ReadLine();
                firstNum = int.Parse(enterNum);
                Console.WriteLine("Enter second number ->");
                enterNum = Console.ReadLine();
                secondNum = int.Parse(enterNum);
                Console.WriteLine("Enter third number ->");
                enterNum = Console.ReadLine();
                thirdNum = int.Parse(enterNum);
                sumNum = (firstNum + secondNum + thirdNum);
                Console.WriteLine("Summ: " + sumNum);
                multiplNum = (firstNum * secondNum * thirdNum);
                Console.WriteLine("Multiplication: " + multiplNum);
            }
            catch (Exception)
            {
                Console.WriteLine("Convertation fail....");
            }
        }
    }
}
