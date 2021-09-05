using Patterns.Zyrian.PatternExample;
using Patterns.Zyrian.Strategy.SimpleTemplate.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.SimpleTemplate
{
    public class SimpleExample : Example
    {
        public override void Start()
        {
            List<BaseContext> contextList = new List<BaseContext>();
            contextList.Add(new FirstContext());
            contextList.Add(new SecondContext());

            foreach (var item in contextList)
            {
                item.PrintInfo();
                item.ExecuteAlghoritm();

                Console.WriteLine();
            }
        }
    }
}
