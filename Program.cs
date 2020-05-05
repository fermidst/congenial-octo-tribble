using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTrpo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var drinks = Fill();
            
            foreach (var drink in drinks) Console.WriteLine(drink);
            
            Console.WriteLine($"{Environment.NewLine}enter id to change price: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var selectedDrink = drinks.Single(d => d.Id == id);
            Console.WriteLine($"{Environment.NewLine}selected drink below:{Environment.NewLine}{selectedDrink}");
            
            Console.WriteLine($"{Environment.NewLine}enter new price:");
            var price = Convert.ToDecimal(Console.ReadLine());
            selectedDrink.Price = price;
            Console.WriteLine($"{Environment.NewLine}price changed, changed drink below:{Environment.NewLine}{selectedDrink}");

            Console.ReadLine();
        }

        private static IList<Drink> Fill()
        {
            var drinks = new List<Drink>();
            for (var i = 0; i < 10; i++)
                if (i % 2 == 0)
                {
                    var isWithMilk = Convert.ToBoolean(i % 2);
                    drinks.Add(new Coffee(i, $"coffee name{i}", i, i + 10, i + 15, i + 1.5, isWithMilk));
                }
                else
                {
                    drinks.Add(new Tea(i, $"tea name {i} ", i, i + 20, i + 10, i + 2.5));
                }

            return drinks;
        }
    }
}