using System;

namespace Domain.FlattenDtos
{
    public record ToolDto(Guid Id, string PathToIcon)
    {
        public Guid Id { get; set; } = Id;
        public string PathToIcon { get; set; } = PathToIcon;
    }
}