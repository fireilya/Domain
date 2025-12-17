using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record AffectedEntityDto(Guid Id, AffectedEntityType AffectedEntityType)
    {
        public Guid Id { get; set; } = Id;
        public AffectedEntityType AffectedEntityType { get; set; } = AffectedEntityType;
    }
}