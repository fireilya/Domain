using System;

namespace Domain.Scheduler
{
    public record Location(Guid Id, string Name, string PathToIcon, Task[] Tasks, Risk Risk)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public Task[] Tasks { get; } = Tasks;
        public Risk Risk { get; } = Risk;
    }
}