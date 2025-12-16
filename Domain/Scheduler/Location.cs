using System.Collections.Generic;

namespace Domain.Scheduler
{
    public record Location(string Name, string PathToIcon, List<Task> Tasks, Risk Risk)
    {
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public List<Task> Tasks { get; } = Tasks;
        public Risk Risk { get; } = Risk;
    }
}