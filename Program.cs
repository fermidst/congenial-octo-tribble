using System;

namespace ConsoleAppTrpo
{
    internal class Program
    {
        private static void Main()
        {
            var drinks = Drink.Fill();

            foreach (var drink in drinks) Console.WriteLine(drink);

            Drink.ChangePrice(drinks);
        }
    }
}