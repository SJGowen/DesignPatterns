namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Flying = FlyBehaviour.FlyNoWay;
            Quacking = QuackBehaviour.Squeak;
        }

        public override string Display => "I'm a rubber duck";
    }
}
