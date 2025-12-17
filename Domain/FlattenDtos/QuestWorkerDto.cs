using System;

namespace Domain.FlattenDtos
{
    public record QuestWorkerDto(Guid Id, Guid WorkerId, Guid QuestId)
    {
        public Guid Id { get; set; } = Id;
        public Guid WorkerId { get; set; } = WorkerId;
        public Guid QuestId { get; set; } = QuestId;
    }
}