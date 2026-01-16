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

        private GameTask _gameTask;

        [JsonIgnore]
        public GameTask GameTask
        {
            get => _gameTask;
            set
            {
                if (_gameTask is null) _gameTask = value;
                else throw new InvalidOperationException("You cannot reassign subtask parent");
            }
        }

        public bool IsUseCapacityTool { get; private set; } = IsUseCapacityTool;
        
        public int Order { get; set; } = Order;

        public Guid LocationID => GameTask.LocationID;

        [JsonIgnore]
        public int DoneProgress { get; private set; } = 0;

        [JsonIgnore] public int CurrentDayProgress { get; set; } = 0;

        public int TotalProgress => DoneProgress + CurrentDayProgress;
        
        public void ResetDayProgress() => CurrentDayProgress = 0;

        public void ApplyDayProgress()
        {
            DoneProgress += CurrentDayProgress;
            CurrentDayProgress = 0;
        }

        public int BaseEfficiency { get; } = BaseEfficiency;

        [JsonIgnore]
        public bool IsDone => _gameTask != null && DoneProgress >= _gameTask.Target;

        [JsonIgnore]
        public Subtask ParentSubtask => GameTask.GetSubtaskParentByOrder(Order);
        
        public bool HasParent => ParentSubtask != null;

        public bool TryGetWorkConstraint(out int maxCanBeDone)
        {
            maxCanBeDone = -1;
            if (Order == 0) return false;
            maxCanBeDone = GameTask!.GetSubtaskParentByOrder(Order)!.TotalProgress - TotalProgress;
            return true;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public void ResetAllProgress()
        {
            DoneProgress = 0;
            CurrentDayProgress = 0;
        }
    }
}