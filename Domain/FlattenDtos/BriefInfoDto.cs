using System;

namespace Domain.FlattenDtos
{
    public record BriefInfoDto(Guid Id, Guid QuestId, bool IsTrue, Guid AffectedEntityId, string Content)
    {
        public Guid Id { get; set; } = Id;
        public Guid QuestId { get; set; } = QuestId;
        public bool IsTrue { get; set; } = IsTrue;
        public Guid AffectedEntityId { get; set; } = AffectedEntityId;
        public string Content { get; set; } = Content;
    }
}