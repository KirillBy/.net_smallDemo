using System;
using System.Linq;
using System.Security.Cryptography;

namespace prc
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!ParamsValidator.GameParamsValidate(args, out string message))
            {
                Console.WriteLine(message);
                return;
            }

            Game game = new Game(args);
            game.Start();
        }
    }
}
