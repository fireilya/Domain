using System;

namespace Domain.Scheduler
{
    public abstract record Subtask(Guid Id, string Name, int BaseEfficiency)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;

        private Task? _parent;

        public Task? Parent
        {
            get => _parent;
            set
            {
                if (_parent is null) _parent = value;
                else throw new InvalidOperationException("You cannot reassign subtask parent");
            }
        }

        public int Progress { get; } = 0;
        public int BaseEfficiency { get; } = BaseEfficiency;

        public bool IsDone => _parent != null && Progress == _parent.Target;
        public abstract int Efficiency { get; }
    }
}