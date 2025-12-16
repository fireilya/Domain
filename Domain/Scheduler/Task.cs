using System.Collections.Generic;
using System.Linq;

namespace Domain.Scheduler
{
    public record Task
    {
        public string Name { get; }
        public uint Target { get; }
        public uint DayLimit { get; }
        public List<Subtask> Subtasks { get; }
        public bool IsTrue { get; }

        public int CurrentSubtaskIndex { get; } = 0;

        public Task(string name, uint target, uint dayLimit, List<Subtask> subtasks, bool isTrue) 
        {
            Name = name;
            Target = target;
            DayLimit = dayLimit;
            Subtasks = subtasks;
            IsTrue = isTrue;

            foreach (var task in Subtasks) task.Parent = this;
        }
        
        public bool IsDone => Subtasks.All(task => task.IsDone);
        
        public Subtask currentSubtask => Subtasks[CurrentSubtaskIndex];
    }
}