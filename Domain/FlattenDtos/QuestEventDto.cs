using System;

namespace Domain.FlattenDtos
{
    public record QuestEventDto(Guid Id, Guid EventId, Guid ResearchAreaId)
    {
        public Guid Id { get; set; } = Id;
        public Guid EventId { get; set; } = EventId;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
    }
}