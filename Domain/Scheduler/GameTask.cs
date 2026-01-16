using System;
using System.Linq;
using System.Text.Json.Serialization;

namespace Domain.Scheduler
{
    public record GameTask
    {
        private Guid _locationID = Guid.Empty;
        public Guid Id { get; }
        public string Name { get; }
        public int Target { get; }
        public short DayLimit { get; }
        public Subtask[] Subtasks { get; }
        public bool IsTrue { get; }

        public Guid LocationID
        {
            get => _locationID;
            set
            {
                if (_locationID == value) return;
                if (_locationID != Guid.Empty) throw new Exception("Reassigning location ID not allowed.");
                _locationID = value;
            }
        }

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
                Subtasks[i].GameTask = this;
                Subtasks[i].Order = (short)i;
            }
        }
        
        public Subtask? GetSubtaskParent(Subtask subtask) => GetSubtaskParentByOrder(subtask.Order);
        
        public Subtask? GetSubtaskParentByOrder(int order) =>
            order == 0 || Subtasks.Length == 0 ? null : Subtasks[order - 1];

        [JsonIgnore]
        public bool IsDone => Subtasks.Last().IsDone;

        [JsonIgnore]
        public int Progress => Subtasks.Last().DoneProgress;

        public void Reset()
        {
            foreach (var subtask in Subtasks) subtask.ResetAllProgress();
        }
    }
}