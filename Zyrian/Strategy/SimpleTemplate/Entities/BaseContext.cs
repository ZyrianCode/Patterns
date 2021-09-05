using Patterns.Zyrian.Strategy.SimpleTemplate.Behaviour.FirstGroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.SimpleTemplate.Entities
{
    public abstract class BaseContext
    {
        protected IStrategy ContextStrategy { get; set; }

        public BaseContext()
        {
            ContextStrategy = new BaseStrategy();
        }
        public void SetStrategy(IStrategy newStrategy) => ContextStrategy = newStrategy;
        public void ExecuteAlghoritm() => ContextStrategy.Algorithm();
        public abstract void PrintInfo();
    }
}
