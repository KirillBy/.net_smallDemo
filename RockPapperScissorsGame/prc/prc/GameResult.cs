using System;
using System.Collections.Generic;
using System.Text;

namespace prc
{
    public static class GameResult
    {
        public static void ShowResult(int userChoice, int compChoice)
        {
            if(userChoice == compChoice)
            {
                Console.WriteLine("Draw");
            }

             if(userChoice > compChoice)
            {
                if(userChoice % 2 == 0 && compChoice % 2 != 0)
                    Console.WriteLine("Computer win");
                if (userChoice % 2 == 0 && compChoice % 2 == 0)
                    Console.WriteLine("User win");
                if (userChoice % 2 != 0 && compChoice % 2 != 0)
                    Console.WriteLine("User win");
                if (userChoice % 2 != 0 && compChoice % 2 == 0)
                    Console.WriteLine("Computer win");
            }
            else
            {
                if (userChoice % 2 == 0 && compChoice % 2 != 0)
                    Console.WriteLine("User win");
                if (userChoice % 2 == 0 && compChoice % 2 == 0)
                    Console.WriteLine("Computer win");
                if (userChoice % 2 != 0 && compChoice % 2 != 0)
                    Console.WriteLine("Computer win");
                if (userChoice % 2 != 0 && compChoice % 2 == 0)
                    Console.WriteLine("User win");
            }
        }
    }
}
