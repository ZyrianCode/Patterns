using Patterns.Zyrian.Strategy.DuckTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public class StrategySelector : Selector
    {
        public override string DisplayMenu()
        {
            Console.WriteLine("For select type one of existed menu operations: ");
            Console.WriteLine("1 - Ducks Example");
            Console.WriteLine("2 - Simple Example");
            Console.WriteLine("3 - Other");
            return Console.ReadLine().ToString();
        }

        public override void StartMenu()
        {
            switch (DisplayMenu())
            {
                case "1":
                    Console.WriteLine("Strategy on Duck example: ");
                    DuckExample duckExample = new DuckExample();
                    duckExample.Start();
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
