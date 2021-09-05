using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public class PatternSelector : Selector
    {
        public override string DisplayMenu()
        {
            Console.WriteLine("For select type one of existed menu operations: ");
            Console.WriteLine("1 - Strategy");
            Console.WriteLine("2 - Factory");
            Console.WriteLine("3 - AbstractFactory");
            return Console.ReadLine().ToString();
        }

        public override void StartMenu()
        {
            switch (DisplayMenu())
            {
                case "1":
                    StrategySelector strategySelector = new StrategySelector();
                    strategySelector.StartMenu();
                    break;
                case "2":
                    Console.WriteLine("Temporary locked...");
                    break;
                case "3":
                    Console.WriteLine("Temporary locked...");
                    break;
                default:
                    Console.WriteLine("Couldn'n find that case...");
                    Console.WriteLine("Open first case.");
                    
                    break;
            }
        }
    }
}
