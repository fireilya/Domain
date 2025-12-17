using System;

namespace Domain.FlattenDtos
{
    public record SubtaskToolDto(Guid Id, Guid ResourceId, Guid SubtaskId)
    {
        public Guid Id { get; set; } = Id;
        public Guid ResourceId { get; set; } = ResourceId;
        public Guid SubtaskId { get; set; } = SubtaskId;
    }
}