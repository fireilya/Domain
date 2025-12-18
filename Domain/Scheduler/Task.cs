using System;
using System.Linq;

namespace Domain.Scheduler
{
    public record Task
    {
        public Guid Id { get; }
        public string Name { get; }
        public int Target { get; }
        public short DayLimit { get; }
        public Subtask[] Subtasks { get; }
        public bool IsTrue { get; }

        public Task(Guid id, string name, int target, short dayLimit, Subtask[] subtasks, bool isTrue)
        {
            Id = id;
            Name = name;
            Target = target;
            DayLimit = dayLimit;
            Subtasks = subtasks;
            IsTrue = isTrue;

            foreach (var task in Subtasks) task.Parent = this;
        }

        public bool IsDone => Subtasks.All(task => task.IsDone);
    }
}