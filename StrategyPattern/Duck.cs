using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        public Func<string> Flying;
        public Func<string> Quacking;

        public Duck() { }

        public abstract string Display { get; }

        public void SetFlyBehavior(Func<string> flyBehaviour) => Flying = flyBehaviour;

        public void SetQuackBehavior(Func<string> quackBehaviour) => Quacking = quackBehaviour;

        public string Fly() => Flying();

        public string Quack() => Quacking();

        public string Swim() => "All ducks float, even decoys!";
    }
}