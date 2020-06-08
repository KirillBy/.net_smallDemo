using System;
using System.Collections.Generic;
using System.Text;

namespace prc
{
    internal class Game
    {
        private readonly string[] _gameParams;
        private bool _gameStatus = false;
        private string _key; 

        public Game(string[] GameParams)
        {
            _gameParams = GameParams;
        }

        public void Start()
        {
            _gameStatus = true;
            do
            {
                Console.WriteLine("\n\n");

                //Computer makes turn
                int compTurn = ComputerChoice(_gameParams.Length);

                //Genarate meny
                MenuGenerator();

                //User making turn
                Console.Write("Enter your move: ");
                string _choice = Console.ReadLine();

                //Validation and result of game 
                if (ChoiceValidator.Validate(_choice, _gameParams.Length))
                {
                    Int32.TryParse(_choice, out int number);
                    if (number == 0)
                    {
                        _gameStatus = false;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Your move: " + _gameParams[number - 1]);
                        Console.WriteLine("Computer move: " + _gameParams[compTurn]);
                        GameResult.ShowResult(number - 1, compTurn);
                        Console.WriteLine("HMAC Key :" + _key);
                    }
                }
                else
                    continue;
            } while (_gameStatus);
        }

        
        private int ComputerChoice(int paramsNumber)
        {
            _key = Generator.GenerateKey();
            Console.WriteLine("HMAC: " + Generator.GenerateHashHMAC(_key, _gameParams[paramsNumber-1]));
            Random random = new Random();
            return random.Next(0, paramsNumber);
        }
        private void MenuGenerator()
        {
            Console.WriteLine("Menu");
            int i = 1;
            foreach (var par in _gameParams)
            {
                Console.WriteLine(i + $" - {par}");
                i++;
            }
            Console.WriteLine("0 - Exit");
        }
    }

}
