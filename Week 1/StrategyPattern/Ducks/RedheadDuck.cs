using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SwimBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
            swimBehavior = new Floating();
        }
        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck");
            quackBehavior.Quack();
            flyBehavior.Fly();
            swimBehavior.Swim();
        }
    }
}
