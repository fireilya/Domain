using System;

namespace Domain.Scheduler
{
    public record ActionArea(Guid Id, string PathToTexture, string Name, Location[] Locations)
    {
        public Guid Id { get; } = Id;
        public string PathToTexture { get; set; } = PathToTexture;
        public string Name { get; set; } = Name;
        public Location[] Locations { get; set; } = Locations;
    }
}