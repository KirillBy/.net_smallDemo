using System;

namespace State_GumBallMachine
{
    public class GumballMachine
    {
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        private IState _currentState;
        public int Count { get; private set; }  = 0;

        public GumballMachine(int numberGumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            Count = numberGumballs;
            _currentState = Count > 0 ? NoQuarterState : SoldOutState;
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

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("Gumball rolling...");
            if (Count != 0)
                Count--;
        }
    }
}