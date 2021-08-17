namespace StrategyPattern
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            Flying = FlyBehaviour.FlyNoWay;
            Quacking = QuackBehaviour.MuteQuack;
        }

        public override string Display => "I'm a model duck";
    }
}
