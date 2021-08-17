namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            SetFlyBehaviour(FlyBehaviour.FlyNoWay);
            SetQuackBehaviour(QuackBehaviour.Squeak);
        }

        public override string Display => "I'm a rubber duck";
    }
}
