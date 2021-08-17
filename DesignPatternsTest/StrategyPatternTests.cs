using StrategyPattern;
using Xunit;

namespace DesignPatternsTest
{
    public class StrategyPatternTests
    {
        [Fact]
        public void MallardDuckTests()
        {
            var mallard = new MallardDuck();
            Assert.Equal("I'm a real Mallard duck", mallard.Display);
            Assert.Equal("I'm flying!!", mallard.Fly());
            Assert.Equal("Quack", mallard.Quack());
            Assert.Equal("All ducks float, even decoys!", mallard.Swim());
        }

        [Fact]
        public void ModelDuckTests()
        {
            var modelDuck = new ModelDuck();
            Assert.Equal("I'm a model duck", modelDuck.Display);
            Assert.Equal("I can't fly", modelDuck.Fly());
            Assert.Equal("<<Silence>>", modelDuck.Quack());
            Assert.Equal("All ducks float, even decoys!", modelDuck.Swim());

            modelDuck.SetFlyBehaviour(FlyBehaviour.FlyRocketPowered);
            Assert.Equal("I'm a model duck", modelDuck.Display);
            Assert.Equal("I'm flying with a rocket", modelDuck.Fly());
            Assert.Equal("<<Silence>>", modelDuck.Quack());
            Assert.Equal("All ducks float, even decoys!", modelDuck.Swim());
        }

        [Fact]
        public void RubberDuckTests()
        {
            var rubberDuck = new RubberDuck();
            Assert.Equal("I'm a rubber duck", rubberDuck.Display);
            Assert.Equal("I can't fly", rubberDuck.Fly());
            Assert.Equal("Squeak!", rubberDuck.Quack());
            Assert.Equal("All ducks float, even decoys!", rubberDuck.Swim());
        }
    }
}
