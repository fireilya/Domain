using System;

namespace Domain.Scheduler
{
    public record Worker(Guid Id, string Name, string PathToIcon, double EfficiencyCoeff)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public double EfficiencyCoeff { get; } = EfficiencyCoeff;
    }
}