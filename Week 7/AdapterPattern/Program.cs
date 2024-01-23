﻿using AdapterPattern.Interfaces;
using AdapterPattern.Turkeys;
using System;

namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's make a duck and a turkey
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();
            // Let's wrap the turkey in an adapter to make it look like a Duck
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            // Testing the turkey.
            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            // Testing the duck with the testDuck() method, which expects a Duck object
            Console.WriteLine("The Duck says...");
            TestDuck(duck);

            // Now let's test the turkey using the testDuck() method
            // (which still expects a Duck object)
            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        // Method to get a duck to call its Quack() and Fly() methods
        static void TestDuck(Duck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}