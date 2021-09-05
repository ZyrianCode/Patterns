using Patterns.Zyrian.Strategy.DuckTemplate;
using Patterns.Zyrian.Strategy.SimpleTemplate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public class StrategySelector : Selector
    {
        public static MenuItem[] Items =
        {
            new MenuItem("Strategy on Duck example: ", new DuckExample()),
            new MenuItem("Strategy on Simple example: ", new SimpleExample())
        };

        public override string DisplayMenu()
        {
            Console.WriteLine("For select type one of existed menu operations: ");
            Console.WriteLine("1 - Ducks Example");
            Console.WriteLine("2 - Simple Example");
            Console.WriteLine("3 - Other");
            return Console.ReadLine().ToString();
        }

        public override void StartMenu() => ShowData(int.Parse(DisplayMenu()));

        public static void ShowData(int id) => Items[id].DisplayInnerMenu();
    }
}
