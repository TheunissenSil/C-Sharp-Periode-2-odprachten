using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Maak een Espresso aan
            IBeverage espresso = new Espresso();
            PrintBeverage(espresso);

            // Maak een Lungo aan
            IBeverage lungo = new Espresso();
            lungo.Size = Size.GRANDE;
            lungo = new Water((Beverage)lungo);
            PrintBeverage(lungo);

            // Maak een Americano aan
            IBeverage americano = new Espresso();
            americano.Size = Size.VENDI;
            americano = new Water((Beverage)americano); 
            americano = new Water((Beverage)americano); 
            PrintBeverage(americano);
        }

        static void PrintBeverage(IBeverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost().ToString("#.##"));
        }
    }
}