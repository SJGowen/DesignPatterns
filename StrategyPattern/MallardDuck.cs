namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Quacking = QuackBehaviour.Quack;
            Flying = FlyBehaviour.FlyWithWings;
        }

        public override string Display => "I'm a real Mallard duck";
    }
}
