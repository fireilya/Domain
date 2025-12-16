namespace Domain.Scheduler
{
    public record Worker(string Name, string PathToIcon, double EfficiencyCoeff)
    {
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public double EfficiencyCoeff { get; } = EfficiencyCoeff;
    }
}