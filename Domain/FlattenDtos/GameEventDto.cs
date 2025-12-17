using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record GameEventDto(
        Guid Id,
        Guid? DistrictId,
        Guid ResearchAreaId,
        GameEventType EventType,
        bool IsPositive,
        string Name,
        string Description,
        short TimeDelayInMinutes,
        float Chance,
        short MaxOccurenceCount,
        string EventData)
    {
        public Guid Id { get; set; } = Id;
        public Guid? DistrictId { get; set; } = DistrictId;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public GameEventType EventType { get; set; } = EventType;
        public bool IsPositive { get; set; } = IsPositive;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public short TimeDelayInMinutes { get; set; } = TimeDelayInMinutes;
        public float Chance { get; set; } = Chance;
        public short MaxOccurenceCount { get; set; } = MaxOccurenceCount;
        public string EventData { get; set; } = EventData;
    }
}