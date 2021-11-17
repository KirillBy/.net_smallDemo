using System;

namespace State_GumBallMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
            gumballMachine.InsertCoin();
            gumballMachine.TurnCrank();
        }
    }
}
