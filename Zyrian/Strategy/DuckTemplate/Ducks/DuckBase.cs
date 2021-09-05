using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly;
using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Ducks
{
    public abstract class DuckBase
    {
        protected IFlyable flyBehaviour;
        protected IQuackable quackBehaviour;

        public DuckBase()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new SimpleQuack();
        }

        public void SetQuackBehaviour(IQuackable newQuackBehaviour) => quackBehaviour = newQuackBehaviour;
        public void SetFlyBehaviour(IFlyable newFlyBehaviour) => flyBehaviour = newFlyBehaviour;

        public void Quack() => quackBehaviour.Quack();

        public void Fly() => flyBehaviour.Fly();

        public void Swim() => Console.WriteLine("I'm swimming!");

        public abstract void Show();
    }
}
