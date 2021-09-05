using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Ducks
{
    public class RubberDuck : DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }
        public override void Show() => Console.WriteLine("I'm Rubbber Duck!");
    }
}
