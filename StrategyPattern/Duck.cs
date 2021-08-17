using System;

namespace StrategyPattern
{
    public abstract class Duck
    {
        private Func<string> Flying;
        private Func<string> Quacking;

        public Duck() { }

        public abstract string Display { get; }

        public void SetFlying(Func<string> flying) => Flying = flying;

        public void SetQuacking(Func<string> quacking) => Quacking = quacking;

        public string Fly() => Flying();

        public string Quack() => Quacking();

        public string Swim() => "All ducks float, even decoys!";
    }
}