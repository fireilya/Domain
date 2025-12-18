using System;
using System.Text.Json.Serialization;

namespace Domain.Scheduler
{
    [JsonDerivedType(typeof(CapacitySubtask), typeDiscriminator: "capacity_subtask")]
    [JsonDerivedType(typeof(ProcessSubtask), typeDiscriminator: "process_subtask")]
    public abstract record Subtask(
        Guid Id,
        string Name,
        int BaseEfficiency,
        bool IsUseCapacityTool
    )
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;

        private GameTask? _parent;

        [JsonIgnore]
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

        [JsonIgnore]
        public Subtask? PreviousSubtask { get; set; } = null;


        [JsonIgnore]
        public int Progress { get; } = 0;

        public int BaseEfficiency { get; } = BaseEfficiency;

        [JsonIgnore]
        public bool IsDone => _parent != null && Progress == _parent.Target;

        [JsonIgnore]
        public abstract int Efficiency { get; }

        [JsonIgnore]
        public int WorkCanBeDone => PreviousSubtask?.Progress ?? Parent!.Target;
    }
}