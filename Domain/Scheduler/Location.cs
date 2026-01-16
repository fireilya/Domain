using System;

namespace Domain.Scheduler
{
    public record Location
    {
        public Location(Guid id, string name, string pathToIcon, GameTask[] tasks, Risk risk, short mappingKey)
        {
            Id = id;
            Name = name;
            PathToIcon = pathToIcon;
            Tasks = tasks;
            Risk = risk;
            MappingKey = mappingKey;

            foreach (var task in Tasks) task.LocationID = Id;
        }

        public Guid Id { get; }
        public string Name { get; }
        public string PathToIcon { get; }
        public GameTask[] Tasks { get; }
        public Risk Risk { get; }
        public short MappingKey {get;}
    }
}