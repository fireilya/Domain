using System;

namespace Domain.FlattenDtos
{
    public record ToolDto(Guid Id, Guid ResourceId, string PathToIcon)
    {
        public Guid Id { get; set; } = Id;
        public Guid ResourceId { get; set; } = ResourceId;
        public string PathToIcon { get; set; } = PathToIcon;
    }
}