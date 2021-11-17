using System;

namespace State_GumBallMachine
{
    public interface IState
    {
        public void InsertCoin();
        public void EjectCoin();
        public void TurnCrank();
        public void Dispense();
    }
    
    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sorry, you are already turned crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.SetState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("It was last gumball, please ask administrator to add gumballs");
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
        }
    }
    
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            Console.WriteLine("No gumballs in machine. Call administrator");
        }

        public void EjectCoin()
        {
            Console.WriteLine("You can't eject coin from empty machine");
        }

        public void TurnCrank()
        {
            Console.WriteLine("No gumballs, action forbidden");
        }

        public void Dispense()
        {
            Console.WriteLine("No gumballs, ask administrator for help");
        }
    }
    
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void EjectCoin()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Illegal action. Please insert quarter first");
        }

        public void Dispense()
        {
            Console.WriteLine("Insert coin first");
        }
    }
    
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random _randomWinner = new Random();    
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            Console.WriteLine("You have already inserted quarter");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Quarter ejected");
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            int winner = _randomWinner.Next(0, 10);
            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.SetState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.SetState(_gumballMachine.SoldState);
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispenced");
        }
    }
    
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void EjectCoin()
        {
            Console.WriteLine("Sorry, you are already turned crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.SetState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("You are winner! Got another gumball");
                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.SetState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs");
                    _gumballMachine.SetState(_gumballMachine.SoldOutState);
                }
            }
        }
    }
}