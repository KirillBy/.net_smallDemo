namespace Strategy_Ducks
{
    public class WoodDuck : Duck
    {
        public WoodDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new MuteQuack();
        }
        
        
        public WoodDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this._flyBehavior = flyBehavior;
            this._quackBehavior = quackBehavior;
        }
    }
}