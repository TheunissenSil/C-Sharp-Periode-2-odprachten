using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    internal class VeryDependentPizzaStore
    {
        public Pizza CreatePizza(string style, string type)
        {
            Pizza pizza = null;

            SimplePizzaFactory factory = new SimplePizzaFactory();
            pizza = factory.CreatePizza(style, type);

            if (pizza != null)
            {
                pizza.Prepare();
                pizza.Bake();
                pizza.Cut();
                pizza.Box();
            }

            return pizza;
        }
    }
}
