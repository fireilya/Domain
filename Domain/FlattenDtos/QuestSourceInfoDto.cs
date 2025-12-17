using System;

namespace Domain.FlattenDtos
{
    public record QuestSourceInfoDto(Guid Id, Guid QuestId, Guid ResearchAreaId, Guid InfoSourceId)
    {
        public Guid Id { get; set; } = Id;
        public Guid QuestId { get; set; } = QuestId;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public Guid InfoSourceId { get; set; } = InfoSourceId;
    }
}