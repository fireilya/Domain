namespace Domain.Scheduler
{
    public abstract record Subtask(string Name, uint BaseEfficiency)
    {
        public string Name { get; } = Name;

        private Task? _parent;
        public Task? Parent
        {
            get => _parent;
            set => _parent ??= value;
        }
        public uint Progress { get; } = 0;
        public uint BaseEfficiency { get; } = BaseEfficiency;
        
        public bool IsDone => _parent != null && Progress == _parent.Target;
        public abstract uint Efficiency { get; }
    }
}