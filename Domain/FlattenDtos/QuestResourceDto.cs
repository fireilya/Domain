using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record QuestResourceDto(Guid Id, Guid QuestId, string Name, ResourceType Type)
    {
        public Guid Id { get; set; } = Id;
        public Guid QuestId { get; set; } = QuestId;
        public string Name { get; set; } = Name;
        public ResourceType Type { get; set; } = Type;
    }
}