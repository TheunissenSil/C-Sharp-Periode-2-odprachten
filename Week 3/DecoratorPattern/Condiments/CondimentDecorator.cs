using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal abstract class CondimentDecorator : IBeverage
    {
        protected IBeverage BaseBeverage { get; set; }

        protected CondimentDecorator(IBeverage baseBeverage)
        {
            BaseBeverage = baseBeverage;
        }

        public abstract string GetDescription();

        public abstract double Cost();

        public Size Size
        {
            get { return BaseBeverage.Size; }
            set { BaseBeverage.Size = value; }
        }
    }
}
