using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Whip : CondimentDecorator
    {
        public Whip(IBeverage beverage) : base(beverage)
        {
        }

        public override double Cost()
        {
            return 0.10 + BaseBeverage.Cost();
        }

        public override string GetDescription()
        {
            return BaseBeverage.GetDescription() + ", Whip";
        }
    }
}
