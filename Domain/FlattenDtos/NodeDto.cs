using System;

namespace Domain.FlattenDtos
{
    public record NodeDto(Guid Id, Guid DistrictId)
    {
        public Guid Id { get; set; } = Id;
        public Guid DistrictId { get; set; } = DistrictId;
    }
}