using Patterns.Zyrian.Strategy.SimpleTemplate.Behaviour.FirstGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.SimpleTemplate.Entities
{
    public class FirstContext : BaseContext
    {
        public FirstContext()
        {
            ContextStrategy = new FirstConcreteStrategy();
        }
        public override void PrintInfo() => Console.WriteLine("FirstContext");
    }

}
