using System;

namespace State_GumBallMachine
{
    public class GumballMachine
    {
        private IState _soldOutState;
        private IState _noQuarterState;
        private IState _hasQuarterState;
        private IState _soldState;

        private IState _currentState;
        private int _count = 0;

        public GumballMachine(int numberGumballs)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            _count = numberGumballs;
            _currentState = _count > 0 ? _noQuarterState : _soldOutState;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public void EjectCoin()
        {
            _currentState.EjectCoin();
        }

        public void TurnCrank()
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Gumball rolling...");
            if (_count != 0)
                _count--;
        }
    }
}