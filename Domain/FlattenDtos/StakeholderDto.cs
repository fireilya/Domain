using System;

namespace Domain.FlattenDtos
{
    public record StakeholderDto(Guid Id, string Name, string PathToIcon)
    {
        public Guid Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string PathToIcon { get; set; } = PathToIcon;
    }
}