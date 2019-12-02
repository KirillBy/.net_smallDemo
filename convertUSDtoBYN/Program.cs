using System;

namespace convertUSDtoBYN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD=0.0, BYN=0.0;
            const double convertRate = 2.11; 
            string sUSD;
            Console.WriteLine("Enter amount of $ ->");
            sUSD = Console.ReadLine();
            try
            {
                USD = double.Parse(sUSD);
                BYN = USD * convertRate;
            }
            catch(Exception)
            {
                Console.WriteLine("Convertation fail....");
               
            }
            Console.WriteLine(USD + "$" + " equals to " + BYN + " BYN.");
        }
    }
}
