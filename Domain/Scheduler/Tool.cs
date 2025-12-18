using System;

namespace Domain.Scheduler
{
    public record Tool(Guid Id, Guid QuestId, string Name, string PathToIcon)
    {
        public Guid Id { get; } = Id;
        public Guid QuestId { get; set; } = QuestId;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
    }
}