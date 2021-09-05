using Patterns.Zyrian.PatternExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public class MenuItem
    {
        public string Description;
        public Selector Selector;
        public Example Example;

        public MenuItem(string description, Selector selector)
        {
            Description = description;
            Selector = selector;
        }
        public MenuItem(string description, Example example)
        {
            Description = description;
            Example = example;
        }

        public void DisplayMenu()
        {
            Console.WriteLine(Description);
            Selector.StartMenu();
        }
        public void DisplayInnerMenu()
        {
            Console.WriteLine(Description);
            Example.Start();
        }
    }
}
