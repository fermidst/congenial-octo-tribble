namespace ConsoleAppTrpo
{
    public class Tea : Drink
    {
        public Tea(long id, string name, int size, decimal price, int energyValue, double extractiveSubstancePercentage)
            : base(id, name, size, price, energyValue)
        {
            ExtractiveSubstancePercentage = extractiveSubstancePercentage;
        }

        private double ExtractiveSubstancePercentage { get; }

        public override string ToString()
        {
            return base.ToString() + $"{$"extra substance %: {ExtractiveSubstancePercentage}",-25}";
        }
    }
}