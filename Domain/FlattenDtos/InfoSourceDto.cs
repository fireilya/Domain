using System;

namespace Domain.FlattenDtos
{
    public record InfoSourceDto(Guid Id, Guid ResearchAreaId, string Name, string InfoText, Guid InfoSourceLevelId)
    {
        public Guid Id { get; set; } = Id;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public string Name { get; set; } = Name;
        public string InfoText { get; set; } = InfoText;
        public Guid InfoSourceLevelId { get; set; } = InfoSourceLevelId;
    }
}