namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlying(FlyBehaviour.FlyNoWay);
            SetQuacking(QuackBehaviour.MuteQuack);
        }

        public override string Display => "I'm a model duck";
    }
}
