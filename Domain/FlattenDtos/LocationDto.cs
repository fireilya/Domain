using System;

namespace Domain.FlattenDtos
{
    public record LocationDto(Guid Id, Guid ActionAreaId, string Name, string PathToIcon, short MappingKey)
    {
        public Guid Id { get; set; } = Id;
        public Guid ActionAreaId { get; set; } = ActionAreaId;
        public string Name { get; set; } = Name;
        public string PathToIcon { get; set; } = PathToIcon;
        public short MappingKey { get; set; } = MappingKey;
    }
}