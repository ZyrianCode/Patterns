using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly
{
    public class NoFly : IFlyable
    {
        public void Fly() => Console.WriteLine("I'm cant fly");
    }
}
