using System;

namespace Domain.FlattenDtos
{
    public record WorkerDto(
        Guid Id,
        string Name,
        string PathToIcon,
        double EffectivenessCoeff
    )
    {
        public Guid Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string PathToIcon { get; set; } = PathToIcon;
        public double EffectivenessCoeff { get; set; } = EffectivenessCoeff;
    }
}