using System;

namespace arithmetical_mean
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum;
            double averageNum;
            string enterNum;
            
            try
            {
               Console.WriteLine("Enter first number ->");
               enterNum = Console.ReadLine();
               firstNum = int.Parse(enterNum);
                Console.WriteLine("Enter second number ->");
                enterNum = Console.ReadLine();
                secondNum = int.Parse(enterNum);
                averageNum = ((double)firstNum + secondNum) / 2;
                Console.WriteLine("Arithmetical mean: " +averageNum);
            }
            catch(Exception)
            {
                Console.WriteLine("Convertation fail....");
            }

            
        }
    }
}
