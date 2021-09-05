using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Ducks
{
    public class ExoticDuck : DuckBase
    {
        public ExoticDuck()
        {
            quackBehaviour = new ExoticQuack();
        }
        public override void Show() => Console.WriteLine("I'm Exotic duck!");
    }
}
