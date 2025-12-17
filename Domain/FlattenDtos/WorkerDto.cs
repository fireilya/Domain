using System;

namespace Domain.FlattenDtos
{
    public record WorkerDto(Guid Id, string Name, double EffectivenessCoeff)
    {
        public Guid Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public double EffectivenessCoeff { get; set; } = EffectivenessCoeff;
    }
}