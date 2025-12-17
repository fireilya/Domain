using System;

namespace Domain.Scheduler
{
    public record Neutralizer(Guid Id, string Name, string PathToIcon)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
    }
}