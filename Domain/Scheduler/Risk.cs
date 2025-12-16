using System;

namespace Domain.Scheduler
{
    public record Risk(double Chance, Neutralizer Neutralizer)
    {
        public double Chance { get; } = Chance;
        public Neutralizer Neutralizer { get; } = Neutralizer;
        private readonly Random _random = new Random();
        public bool IsNeutralizerFound { get; set; }
        public bool IsWorked => !IsNeutralizerFound && _random.NextDouble() < Chance;
    }
}