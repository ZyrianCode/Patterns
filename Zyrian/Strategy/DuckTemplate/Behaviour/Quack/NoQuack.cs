using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Quack
{
    public class NoQuack : IQuackable
    {
        public void Quack() => Console.WriteLine("I'm cant quack!");
    }
}
