using System;

namespace Domain.Scheduler
{
    public record Worker(Guid Id, string Name, string PathToIcon, float EfficiencyCoeff)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public float EfficiencyCoeff { get; } = EfficiencyCoeff;
    }
}