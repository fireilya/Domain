using System;

namespace Domain.Scheduler
{
    public record Risk(
        Guid Id,
        Neutralizer Neutralizer
    )
    {
        public Guid Id { get; } = Id;
        public double Chance { get; } = 0.5;
        public Neutralizer Neutralizer { get; } = Neutralizer;
        public bool IsNeutralizerFound { get; set; }
        public bool IsWorked => !IsNeutralizerFound && _random.NextDouble() < Chance;

        private readonly Random _random = new();
    }
}