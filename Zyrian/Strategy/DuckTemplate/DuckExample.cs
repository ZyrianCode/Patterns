using Patterns.Zyrian.PatternExample;
using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Fly;
using Patterns.Zyrian.Strategy.DuckTemplate.Behaviour.Quack;
using Patterns.Zyrian.Strategy.DuckTemplate.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Zyrian.Strategy.DuckTemplate
{
    public class DuckExample : Example
    {   
        public override void Start()
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new SimpleDuck());
            ducks.Add(new ExoticDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Show();
                duck.Swim();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

            DuckBase upgradableDuck = new UpgradableDuck();
            upgradableDuck.Show();
            upgradableDuck.Swim();
            upgradableDuck.Quack();
            upgradableDuck.Fly();

            upgradableDuck.SetFlyBehaviour(new FlyWithWings());
            upgradableDuck.SetQuackBehaviour(new ExoticQuack());
            upgradableDuck.Quack();
            upgradableDuck.Fly();

            Console.ReadKey();
        }
    }
}
