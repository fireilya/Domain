using System;

namespace Domain.FlattenDtos
{
    public record ObstacleDto(
        Guid Id,
        Guid ResearchAreaId,
        string Name,
        string Description,
        short TimeDelayInMinutes,
        short MaxInstance,
        string PathToIcon)
    {
        public Guid Id { get; set; } = Id;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
        public short TimeDelayInMinutes { get; set; } = TimeDelayInMinutes;
        public short MaxInstance { get; set; } = MaxInstance;
        public string PathToIcon { get; set; } = PathToIcon;
    }
}