namespace ConsoleAppTrpo
{
    public class Coffee : Drink
    {
        public Coffee(long id, string name, int size, decimal price, int energyValue, double caffeinePercentage,
            bool isWithMilk) : base(id, name, size, price, energyValue)
        {
            CaffeinePercentage = caffeinePercentage;
            IsWithMilk = isWithMilk;
        }

        private double CaffeinePercentage { get; }

        private bool IsWithMilk { get; }

        public override string ToString()
        {
            return base.ToString() + $"{$"caffeine %: {CaffeinePercentage}",-25} | milk: {IsWithMilk}";
        }
    }
}