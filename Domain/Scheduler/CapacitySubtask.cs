using System;
using System.Collections.Generic;

namespace Domain.Scheduler
{
    public record CapacitySubtask(
        Guid Id,
        string Name,
        int BaseEfficiency,
        int Order,
        bool IsUseCapacityTool,
        int BaseCapacity,
        IReadOnlyDictionary<Guid, short> ToolsCapacity
    ) : Subtask(Id, Name, BaseEfficiency, Order, IsUseCapacityTool)
    {
        public int BaseCapacity { get; } = BaseCapacity;
        public IReadOnlyDictionary<Guid, short> ToolsCapacity { get; } = ToolsCapacity;
        public int GetEfficiency => BaseEfficiency;

        public int GetToolCapacity(Guid toolID) => ToolsCapacity.ContainsKey(toolID) ? ToolsCapacity[toolID] : BaseCapacity;
    }
}