using System;

namespace Domain.Scheduler
{
    public abstract record Subtask(Guid Id, string Name, int BaseEfficiency, bool IsUseCapacityTool)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;

        private GameTask? _parent;

        public GameTask? Parent
        {
            get => _parent;
            set
            {
                if (_parent is null) _parent = value;
                else throw new InvalidOperationException("You cannot reassign subtask parent");
            }
        }

        public bool IsUseCapacityTool { get; set; } = IsUseCapacityTool;
        public Subtask? PreviousSubtask { get; set; } = null;
        public int Progress { get; } = 0;
        public int BaseEfficiency { get; } = BaseEfficiency;
        public bool IsDone => _parent != null && Progress == _parent.Target;
        public abstract int Efficiency { get; }
        public int WorkCanBeDone => PreviousSubtask?.Progress ?? Parent!.Target;
    }
}