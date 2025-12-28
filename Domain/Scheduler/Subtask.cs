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
        int Order,
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

        public bool IsUseCapacityTool { get; private set; } = IsUseCapacityTool;
        
        public int Order { get; set; } = Order;

        [JsonIgnore]
        public int Progress { get; set; } = 0;

        public int BaseEfficiency { get; } = BaseEfficiency;

        [JsonIgnore]
        public bool IsDone => _parent != null && Progress == _parent.Target;

        public bool TryGetWorkConstraint(out int maxCanBeDone)
        {
            maxCanBeDone = -1;
            if (Order == 0) return false;
            maxCanBeDone = Parent!.GetSubtaskParentByOrder(Order)!.Progress;
            return true;
        }
    }
}