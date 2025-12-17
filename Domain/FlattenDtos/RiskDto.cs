using System;

namespace Domain.FlattenDtos
{
    public record RiskDto(Guid Id, Guid NeutralizerId, Guid LocationId)
    {
        public Guid Id { get; set; } = Id;
        public Guid NeutralizerId { get; set; } = NeutralizerId;
        public Guid LocationId { get; set; } = LocationId;
    }
}