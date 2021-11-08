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
            throw new System.NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }
    }
    
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this._gumballMachine = gumballMachine;
        }
        
        public void InsertCoin()
        {
            throw new System.NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }

        public void EjectCoin()
        {
            throw new System.NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new System.NotImplementedException();
        }

        public void Dispense()
        {
            throw new System.NotImplementedException();
        }
    }
}