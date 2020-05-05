namespace ConsoleAppTrpo
{
    public abstract class Drink
    {
        public Drink(long id, string name, int size, decimal price, int energyValue)
        {
            Id = id;
            Name = name;
            Size = size;
            Price = price;
            EnergyValue = energyValue;
        }

        public long Id { get; set; }

        public string Name { get; }

        public int Size { get; }

        public decimal Price { get; set; }

        public int EnergyValue { get; }

        public override string ToString()
        {
            return
                $"{$"id: {Id}", -6} | " +
                $"{$"name: {Name}",-20} | " +
                $"{$"price: {Price} rub",-15} | " +
                $"{$"size: {Size} ml",-12} | " +
                $"energy: {EnergyValue} kcal/g | ";
        }
    }
}