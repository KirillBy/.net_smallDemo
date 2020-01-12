using System;
using System.Text;

namespace TikTakToeGame
{
    class Program
    {
        private static TikTakToe g = new TikTakToe();
        static void Main(string[] args)
        {
            Console.WriteLine(GetPrintableState());
            while(g.GetWinner() == Winner.GameIsUnfinished)
            {
                if(g.MovesCounter%2 == 0)
                    Console.WriteLine("X player turn");
                else
                    Console.WriteLine("O player turn");
                int index = int.Parse(Console.ReadLine());
                g.MakeMove(index);
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine(GetPrintableState());
            }
            Console.WriteLine($"Result: {g.GetWinner()} win");
            
        }
        static string GetPrintableState()
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= 7; i+=3)
            {
                sb.AppendLine("     |     |     |").AppendLine(
                    $"  {GetPrintableChar(i)}  |  {GetPrintableChar(i + 1)}  |  {GetPrintableChar(i + 2)}  |")
                    .AppendLine("_____|_____|_____|");
            }
            return sb.ToString();
        }
        static string GetPrintableChar(int index)
        {
            State state = g.GetState(index);
            if (state == State.Unset)
                return index.ToString();
            return state == State.Cross ? "X" : "O";
        }
    }
}
