using System;
using System.Collections.Generic;
using System.Text;

namespace GuessNumber
{
    public enum GuessingPlayer
    {
        Human,
        Machine
    }
    class GuessNumberGame
    {
        private readonly int max;
        private readonly int maxTries;
        private readonly GuessingPlayer guessingPlayer;

        public GuessNumberGame(int max = 100, int maxTries = 5, GuessingPlayer guessingPlayer = GuessingPlayer.Human)
        {
            this.max = max;
            this.maxTries = maxTries;
            this.guessingPlayer = guessingPlayer;
        }
        public void Start()
        {
            if(guessingPlayer == GuessingPlayer.Human)
            {
                HumanGuesses();
            }
            else
            {
                MachineGuesses();
            }
        }

        private void MachineGuesses()
        {
            Console.WriteLine("Enter the number(0 to 100)");
            int guessedNumber = -1;
            while (guessedNumber == -1)
            {
                int parsedNumber = int.Parse(Console.ReadLine());
                if (parsedNumber >= 0 && parsedNumber <= this.max)
                    guessedNumber = parsedNumber;
            }
            int lastGuess = -1;
            int min = 0;
            int max = this.max;
            int tries = 0;
            while (lastGuess != guessedNumber && tries < maxTries)
            {
                lastGuess = (min + max) / 2;
                Console.WriteLine($"Computers number is {lastGuess}");
               if(lastGuess == guessedNumber)
                {
                    Console.WriteLine("Computer win");
                    break;
                }
                else if (lastGuess < guessedNumber)
                {
                    min = lastGuess;
                }
                else
                {
                    max = lastGuess;
                }
                tries++;
                if(tries == maxTries)
                {
                    Console.WriteLine("Computer lost");
                }

            }

        }

        private void HumanGuesses()
        {
            Random random = new Random();
            int guessedNumbers = random.Next(0, max);
            int lastGuess = -1;
            int tries = 0;
            while (lastGuess != guessedNumbers && tries < maxTries)
            {
                Console.WriteLine("Enter the number ");
                lastGuess = int.Parse(Console.ReadLine());
                if(lastGuess == guessedNumbers)
                {
                    Console.WriteLine("Congratulation!!! You win");
                    break;
                }
                else if (lastGuess < guessedNumbers)
                {
                    Console.WriteLine("Guessed number is greater than your's ");
                }
                else
                {
                    Console.WriteLine("Guessed number is less than your's ");
                }
                tries++;
                if(tries == maxTries)
                {
                    Console.WriteLine("You Lost");
                }
            }
        }
    }
}
