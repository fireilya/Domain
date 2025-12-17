using System;

namespace Domain.FlattenDtos
{
    public record SaveDto(Guid Id, DateTime Time)
    {
        public Guid Id { get; set; } = Id;
        public DateTime Time { get; set; } = Time;
    }
}