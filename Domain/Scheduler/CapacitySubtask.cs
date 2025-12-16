using System;
using System.Collections.Generic;

namespace Domain.Scheduler
{
    public record CapacitySubtask(string Name, uint BaseEfficiency, uint BaseCapacity, Dictionary<Tool, uint> ToolsCapacity) :
        Subtask(Name, BaseEfficiency)
    {
        public uint BaseCapacity { get; } = BaseCapacity;
        public Dictionary<Tool, uint> ToolsCapacity { get; } = ToolsCapacity;
        public Tool? ChosenTool { get; set; } = null;

        public override uint Efficiency => BaseEfficiency;
    }
}