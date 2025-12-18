using System;

namespace Domain.FlattenDtos
{
    public record TaskDto(Guid Id, Guid LocationId, string Name, int Target, short DayLimit, bool IsTrue)
    {
        public Guid Id { get; set; } = Id;
        public Guid LocationId { get; set; } = LocationId;
        public string Name { get; set; } = Name;
        public int Target { get; set; } = Target;
        public short DayLimit { get; set; } = DayLimit;
        public bool IsTrue { get; set; } = IsTrue;
    }
}