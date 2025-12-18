using System;

namespace Domain.FlattenDtos
{
    public record ActionAreaDto(Guid Id, string PathToTexture)
    {
        public Guid Id { get; set; } = Id;
        public string PathToTexture { get; set; } = PathToTexture;
    }
}