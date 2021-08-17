namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlying(FlyBehaviour.FlyNoWay);
            SetQuacking(QuackBehaviour.Squeak);
        }

        public override string Display => "I'm a rubber duck";
    }
}
