using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleAppTrpo
{
    public abstract class Drink
    {
        protected Drink(long id, string name, int size, decimal price, int energyValue)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = price;
            EnergyValue = energyValue;
        }

        private long Id { get; }

        private string Name { get; }

        private int Size { get; }

        private decimal Price { get; set; }

        private int EnergyValue { get; }

        public static void ChangePrice(IEnumerable<Drink> drinks)
        {
            Console.WriteLine($"{Environment.NewLine}enter id to change price: ");
            var id = Convert.ToInt32(Console.ReadLine());
            var selectedDrink = drinks.Single(d => d.Id == id);
            Console.WriteLine($"{Environment.NewLine}selected drink below:{Environment.NewLine}{selectedDrink}");

            Console.WriteLine($"{Environment.NewLine}enter new price:");
            var price = Convert.ToDecimal(Console.ReadLine());
            selectedDrink.Price = price;
            Console.WriteLine(
                $"{Environment.NewLine}price changed, changed drink below:{Environment.NewLine}{selectedDrink}");
        }

        public static IList<Drink> Fill()
        {
            var drinks = new List<Drink>();
            for (var i = 0; i < 10; i++)
                if (i % 2 == 0)
                {
                    var isWithMilk = Convert.ToBoolean(i % 2);
                    drinks.Add(new Coffee(i, $"coffee name {i}", i, i + 10, i + 15, i + 1.5, isWithMilk));
                }
                else
                {
                    drinks.Add(new Tea(i, $"tea name {i} ", i, i + 20, i + 10, i + 2.5));
                }

            return drinks;
        }

        public override string ToString()
        {
            return
                $"{$"id: {Id}",-6} | " +
                $"{$"name: {Name}",-20} | " +
                $"{$"price: {Price} rub",-15} | " +
                $"{$"size: {Size} ml",-12} | " +
                $"energy: {EnergyValue} kcal/g | ";
        }
    }
}