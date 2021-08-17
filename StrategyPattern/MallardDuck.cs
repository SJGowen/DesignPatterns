namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetQuacking(QuackBehaviour.Quack);
            SetFlying(FlyBehaviour.FlyWithWings);
        }

        public override string Display => "I'm a real Mallard duck";
    }
}
