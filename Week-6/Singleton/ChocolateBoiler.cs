using System;

namespace Singleton
{
    internal sealed class ChocolateBoiler
    {
        private static readonly ChocolateBoiler instance = new ChocolateBoiler();
        private bool empty;
        private bool boiled;

        // Private constructor to prevent instantiation from outside
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler Instance
        {
            get { return instance; }
        }

        public bool IsEmpty { get { return empty; } }
        public bool IsBoiled { get { return boiled; } }

        // To fill the boiler it must be empty and once it is full, we set the empty and boiled flag
        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        // To drain the boiler, it must be full (non empty) and also boiled.
        // Once it is drained we set empty back to true
        public void Drain()
        {
            if (!empty && boiled)
            {
                empty = true;
            }
        }

        // To boil the mixture, the boiler has to be full and not already boiled.
        // Once it is boiled we set the boiled flag to true
        public void Boil()
        {
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }
    }
}
