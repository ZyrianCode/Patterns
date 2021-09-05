using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Menu
{
    public abstract class Selector
    {
        public abstract string DisplayMenu();
        public abstract void StartMenu();
    }
}
