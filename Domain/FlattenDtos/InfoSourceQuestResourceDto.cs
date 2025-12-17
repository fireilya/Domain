using System;

namespace Domain.FlattenDtos
{
    public record InfoSourceQuestResourceDto(Guid Id, Guid InfoSourceId, Guid ResourceId)
    {
        public Guid Id { get; set; } = Id;
        public Guid InfoSourceId { get; set; } = InfoSourceId;
        public Guid ResourceId { get; set; } = ResourceId;
    }
}