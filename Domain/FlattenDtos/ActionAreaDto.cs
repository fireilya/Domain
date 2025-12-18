using System;

namespace Domain.FlattenDtos
{
    public record ActionAreaDto(Guid Id, string PathToTexture, string Name)
    {
        public Guid Id { get; set; } = Id;
        public string PathToTexture { get; set; } = PathToTexture;
        public string Name { get; set; } = Name;
    }
}