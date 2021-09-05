using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly;
using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Ducks
{
    public class UpgradableDuck : DuckBase
    {
        public UpgradableDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }
        public override void Show() => Console.WriteLine("I'm an upgradable duck!");
    }
}
