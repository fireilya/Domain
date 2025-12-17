using System;

namespace Domain.FlattenDtos
{
    public record HealthPhraseDto(Guid Id, string Text, int ShowCount)
    {
        public Guid Id { get; set; } = Id;
        public string Text { get; set; } = Text;
        public int ShowCount { get; set; } = ShowCount;
    }
}