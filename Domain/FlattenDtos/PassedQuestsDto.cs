using System;

namespace Domain.FlattenDtos
{
    public record PassedQuestsDto(Guid Id, Guid SaveId, Guid QuestId, short Score)
    {
        public Guid Id { get; set; } = Id;
        public Guid SaveId { get; set; } = SaveId;
        public Guid QuestId { get; set; } = QuestId;
        public short Score { get; set; } = Score;
    }
}