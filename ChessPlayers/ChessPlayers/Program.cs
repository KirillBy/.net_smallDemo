using System;
using System.IO;
using System.Linq;

namespace ChessPlayers
{
    class Program
    {
        static void Main(string[] args)
        {
            HW_FindRusChessPlayers();
        }
        static void HW_FindRusChessPlayers()
        {
            var players = File.ReadAllLines(@"Top100ChessPlayers.csv")
                              .Skip(1)
                              .Select(ChessPlayer.ParseFideCsvLine)
                              .Where(player => player.Country == "RUS")
                              .OrderBy(player => player.BirthYear)
                              .ToList();

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadLine();
        }
    }
}
