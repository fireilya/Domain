using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record PlayerSettingsDto(
        Guid Id,
        Guid PlayerId,
        GameScreenMode EventType,
        short MusicVolume,
        short SfxVolume,
        short TextSpeed)
    {
        public Guid Id { get; set; } = Id;
        public Guid PlayerId { get; set; } = PlayerId;
        public GameScreenMode EventType { get; set; } = EventType;
        public short MusicVolume { get; set; } = MusicVolume;
        public short SfxVolume { get; set; } = SfxVolume;
        public short TextSpeed { get; set; } = TextSpeed;
    }
}