using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.SimpleTemplate.Behaviour.FirstGroup
{
    public class FirstConcreteStrategy : IStrategy
    {
        public void Algorithm() => Console.WriteLine("First");
    }
}
