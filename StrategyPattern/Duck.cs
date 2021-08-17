using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private Func<string> Flying;
        private Func<string> Quacking;

        public Duck() { }

        public abstract string Display { get; }

        public void SetFlyBehaviour(Func<string> flyBehaviour) => Flying = flyBehaviour;

        public void SetQuackBehaviour(Func<string> quackBehaviour) => Quacking = quackBehaviour;

        public string Fly() => Flying();

        public string Quack() => Quacking();

        public string Swim() => "All ducks float, even decoys!";
    }
}