using System;

namespace Domain.FlattenDtos
{
    public record DistrictDto(Guid Id, Guid ResearchAreaId, string Name, string Description)
    {
        public Guid Id { get; set; } = Id;
        public Guid ResearchAreaId { get; set; } = ResearchAreaId;
        public string Name { get; set; } = Name;
        public string Description { get; set; } = Description;
    }
}