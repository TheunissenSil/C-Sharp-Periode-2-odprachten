using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal interface IBeverage
    {
        Size Size { get; set; }
        string GetDescription();
        double Cost();
    }
}
