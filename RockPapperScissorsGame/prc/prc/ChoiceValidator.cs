using System;
using System.Collections.Generic;
using System.Text;

namespace prc
{
    public static class ChoiceValidator
    {
        public static bool Validate(string choice, int length)
        {
            if (Int32.TryParse(choice, out int number))
            {
                if(number <= length && number >= 0)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Choose number from menu!!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Incorrent number format!!!!");
                return false;
            }
        }
    }
}
