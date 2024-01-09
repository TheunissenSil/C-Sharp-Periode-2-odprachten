using SimpleFactory;

internal class SimplePizzaFactory
{
    public virtual Pizza CreatePizza(string style, string type)
    {
        Pizza pizza = null;

        switch (style)
        {
            case "NY":
                pizza = CreateNYPizza(type);
                break;
            case "Chicago":
                pizza = CreateChicagoPizza(type);
                break;
            case "California":
                pizza = CreateCaliforniaPizza(type);
                break;
            default:
                Console.WriteLine("Error: Invalid input");
                break;
        }

        return pizza;
    }

    private Pizza CreateNYPizza(string type)
    {
        Pizza pizza = null;

        switch (type)
        {
            case "cheese":
                pizza = new NYStyleCheesePizza();
                break;
            case "pepperoni":
                pizza = new NYStylePepperoniPizza();
                break;
            case "clam":
                pizza = new NYStyleClamPizza();
                break;
            case "veggie":
                pizza = new NYStyleVeggiePizza();
                break;
        }

        return pizza;
    }

    private Pizza CreateChicagoPizza(string type)
    {
        Pizza pizza = null;

        switch (type)
        {
            case "cheese":
                pizza = new ChicagoStyleCheesePizza();
                break;
            case "pepperoni":
                pizza = new ChicagoStylePepperoniPizza();
                break;
            case "clam":
                pizza = new ChicagoStyleClamPizza();
                break;
            case "veggie":
                pizza = new ChicagoStyleVeggiePizza();
                break;
        }

        return pizza;
    }

    private Pizza CreateCaliforniaPizza(string type)
    {
        Pizza pizza = null;

        switch (type)
        {
            case "cheese":
                pizza = new CaliforniaStyleCheesePizza();
                break;
            case "pepperoni":
                pizza = new CaliforniaStylePepperoniPizza();
                break;
            case "clam":
                pizza = new CaliforniaStyleClamPizza();
                break;
            case "veggie":
                pizza = new CaliforniaStyleVeggiePizza();
                break;
        }

        return pizza;
    }
}
