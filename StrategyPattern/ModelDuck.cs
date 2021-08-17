namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehaviour(FlyBehaviour.FlyNoWay);
            SetQuackBehaviour(QuackBehaviour.MuteQuack);
        }

        public override string Display => "I'm a model duck";
    }
}
