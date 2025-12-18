using System;
using System.Collections.Generic;

namespace Domain.Scheduler
{
    public record CapacitySubtask(
        Guid Id,
        string Name,
        int BaseEfficiency,
        bool IsUseCapacityTool,
        int BaseCapacity,
        IReadOnlyDictionary<Guid, short> ToolsCapacity
    ) : Subtask(Id, Name, BaseEfficiency, IsUseCapacityTool)
    {
        public int BaseCapacity { get; } = BaseCapacity;
        public IReadOnlyDictionary<Guid, short> ToolsCapacity { get; } = ToolsCapacity;
        public Tool? ChosenTool { get; set; } = null;

        public override int Efficiency => BaseEfficiency;
    }
}