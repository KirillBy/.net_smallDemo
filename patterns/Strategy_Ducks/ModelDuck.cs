namespace Strategy_Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackBehavior = new Quack();
        }

        public ModelDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            this._flyBehavior = flyBehavior;
            this._quackBehavior = quackBehavior;
        }
    }
}