using System;

namespace Domain.FlattenDtos
{
    public record SubtaskDto(
        Guid Id,
        Guid AffectedEntityId,
        string Name,
        short Order,
        int BaseEffectiveness,
        bool IsUseCapacityTool)
    {
        public Guid Id { get; set; } = Id;
        public Guid AffectedEntityId { get; set; } = AffectedEntityId;
        public string Name { get; set; } = Name;
        public short Order { get; set; } = Order;
        public int BaseEffectiveness { get; set; } = BaseEffectiveness;
        public bool IsUseCapacityTool { get; set; } = IsUseCapacityTool;
    }
}