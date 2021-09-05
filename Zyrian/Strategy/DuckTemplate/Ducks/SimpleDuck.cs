using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Ducks
{
    public class SimpleDuck : DuckBase
    {
        public override void Show() => Console.WriteLine("I'm simple duck!");
    }
}
