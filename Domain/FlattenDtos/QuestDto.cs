using System;

namespace Domain.FlattenDtos
{
    public record QuestDto(
        Guid Id,
        string Name,
        string Description,
        int Parent,
        Guid StakeholderId,
        Guid ResearchAreaId,
        Guid ActionAreaId,
        short MaxQuestionsCount)
    {
        public Guid Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public int Parent { get; set; } = Parent;
        public Guid StakeholderId { get; set; } = StakeholderId;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public Guid ActionAreaId { get; set; } = ActionAreaId;
        public short MaxQuestionsCount { get; set; } = MaxQuestionsCount;
    }
}