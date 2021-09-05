using Patterns.Zyrian.Strategy.SimpleTemplate.Behaviour.FirstGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.SimpleTemplate.Entities
{
    public class SecondContext : BaseContext
    {
        public SecondContext()
        {
            ContextStrategy = new SecondConcreteStrategy();
        }
        public override void PrintInfo() => Console.WriteLine("SecondContext");
    }
}
