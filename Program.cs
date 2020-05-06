using System;
using System.Threading.Tasks;

namespace ConsoleAppTrpo
{
    internal class Program
    {
        private static async Task Main()
        {
            Console.WindowWidth = 135;

            var drinks = Drink.Fill();

            while (true)
            {
                foreach (var drink in drinks) Console.WriteLine(drink);
                Drink.ChangePrice(drinks);
                Console.WriteLine($"{Environment.NewLine}updating list");
                await Task.Delay(2000);
                Console.Clear();
            }
        }
    }
}