using System;
using System.Linq;
using JetBrains.Annotations;

namespace Domain.Scheduler
{
    public record GameTask
    {
        public Guid Id { get; }
        public string Name { get; }
        public int Target { get; }
        public short DayLimit { get; }
        public Subtask[] Subtasks { get; }
        public bool IsTrue { get; }

        public GameTask(Guid id, string name, int target, short dayLimit, Subtask[] subtasks, bool isTrue)
        {
            Id = id;
            Name = name;
            Target = target;
            DayLimit = dayLimit;
            Subtasks = subtasks.OrderBy(x => x.Order).ToArray();
            IsTrue = isTrue;
            for (var i = 0; i < Subtasks.Length; i++)
            {
                Subtasks[i].Parent = this;
                Subtasks[i].Order = i;
            }
        }

        [CanBeNull]
        public Subtask GetSubtaskParent(Subtask subtask) => GetSubtaskParentByOrder(subtask.Order);

        [CanBeNull]
        public Subtask GetSubtaskParentByOrder(int order) =>
            order == 0 || Subtasks.Length == 0 ? null : Subtasks[order - 1];

        public bool IsDone => Subtasks.Last().IsDone;

        public int Progress => Subtasks.Last().Progress;
    }
}