using System;

namespace Domain.Scheduler
{
    public record Risk(
        Guid Id,
        string PathToIcon,
        string Description,
        Neutralizer Neutralizer
    )
    {
        public Guid Id { get; } = Id;
        public string PathToIcon { get; } = PathToIcon;
        public string Description { get; } = Description;
        public double Chance { get; } = 0.5;
        public Neutralizer Neutralizer { get; } = Neutralizer;
        public bool IsNeutralizerFound { get; set; }
        public bool IsWorked => !IsNeutralizerFound && _random.NextDouble() < Chance;

        private readonly Random _random = new();
    }
}