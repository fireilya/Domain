using System;

namespace Domain.FlattenDtos
{
    public record SubtaskCapacityToolDto(Guid Id, Guid? ResourceId, Guid SubtaskId, short Capacity)
    {
        public Guid Id { get; set; } = Id;
        public Guid? ResourceId { get; set; } = ResourceId;
        public Guid SubtaskId { get; set; } = SubtaskId;
        public short Capacity { get; set; } = Capacity;
    }
}