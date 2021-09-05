using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public class PatternSelector : Selector
    {
        public static MenuItem[] Items =
        {
            new MenuItem("Strategy Menu", new StrategySelector())
        };

        public override string DisplayMenu()
        {
            Console.WriteLine("For select type one of existed menu operations: ");
            Console.WriteLine("1 - Strategy");
            Console.WriteLine("2 - Factory");
            Console.WriteLine("3 - AbstractFactory");
            return Console.ReadLine().ToString();
        }

        public override void StartMenu() => ShowData(int.Parse(DisplayMenu()));

        public static void ShowData(int id) => Items[id].DisplayMenu();
    }
}
