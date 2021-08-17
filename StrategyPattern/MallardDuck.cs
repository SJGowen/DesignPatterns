namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetQuackBehaviour(QuackBehaviour.Quack);
            SetFlyBehaviour(FlyBehaviour.FlyWithWings);
        }

        public override string Display => "I'm a real Mallard duck";
    }
}
