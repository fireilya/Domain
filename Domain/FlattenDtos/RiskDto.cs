using System;

namespace Domain.FlattenDtos
{
    public record RiskDto(
        Guid Id,
        string PathToIcon,
        string Description,
        Guid NeutralizerId,
        Guid LocationId)
    {
        public Guid Id { get; set; } = Id;
        public string PathToIcon { get; set; } = PathToIcon;
        public string Description { get; set; } = Description;
        public Guid NeutralizerId { get; set; } = NeutralizerId;
        public Guid LocationId { get; set; } = LocationId;
    }
}