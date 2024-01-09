using SimpleFactory;

internal class PizzaStore
{
    SimplePizzaFactory factory;

    public PizzaStore(SimplePizzaFactory factory)
    {
        this.factory = factory;
    }

    public Pizza OrderPizza(string style, string type)
    {
        Pizza pizza = factory.CreatePizza(style, type);

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
