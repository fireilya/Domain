using System;

namespace Domain.FlattenDtos
{
    public record QuestObstacleDto(Guid Id, Guid ObstacleId, Guid ResearchAreaId)
    {
        public Guid Id { get; set; } = Id;
        public Guid ObstacleId { get; set; } = ObstacleId;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
    }
}