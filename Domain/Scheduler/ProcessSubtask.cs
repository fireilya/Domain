using System;

namespace Domain.Scheduler
{
    public record ProcessSubtask(
        Guid Id, 
        string Name, 
        int BaseEfficiency, 
        short Order,
        bool IsUseCapacityTool, 
        Guid NeededToolId) :
        Subtask(Id, Name, BaseEfficiency, Order, IsUseCapacityTool)
    {
        public double GetWorkToolCoeff(Guid toolId) => (toolId != NeededToolId ? 0.5 : 1.0);
        public Guid NeededToolId { get; } = NeededToolId;
        public int GetWithToolEfficiency(Guid toolId) => (int)(BaseEfficiency * GetWorkToolCoeff(toolId));
    }
}