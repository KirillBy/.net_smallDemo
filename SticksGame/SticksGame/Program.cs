using System;

namespace SticksGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new StickGame(10, Player.Human);
            game.MachinePlayed += Game_MachinePlayed;
            game.HumanTurnToMakeMove += Game_HumanTurnToMakeMove;
            game.EndOfGame += Game_EndOfGame;

            game.Start();
        }

        private static void Game_EndOfGame(Player player)
        {
            Console.WriteLine($"Winner:{player}");
        }

        private static void Game_HumanTurnToMakeMove(object sender, int remainingSticks)
        {
            Console.WriteLine($"Remaining sticks:{remainingSticks}");
            Console.WriteLine("Take some sticks");

            bool takeCorrectly = false;
            while(!takeCorrectly)
            {
                if(int.TryParse(Console.ReadLine(), out int takenSticks))
                {
                    var game = (StickGame)sender;
                    try
                    {
                        game.HumanTakes(takenSticks);
                        takeCorrectly = true;
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void Game_MachinePlayed(int sticksTaken)
        {
            Console.WriteLine($"Machine took:{sticksTaken}");
        }
    }
}
