using System;

namespace Domain.Scheduler
{
    public record Location(Guid Id, string Name, string PathToIcon, GameTask[] Tasks, Risk Risk)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public GameTask[] Tasks { get; } = Tasks;
        public Risk Risk { get; } = Risk;
    }
}