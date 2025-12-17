using System;
using System.Collections.Generic;

namespace Domain.Scheduler
{
    public record CapacitySubtask(
        Guid Id, 
        string Name, 
        int BaseEfficiency, 
        int BaseCapacity, 
        IReadOnlyDictionary<Guid, uint> ToolsCapacity) :
        Subtask(Id, Name, BaseEfficiency)
    {
        public int BaseCapacity { get; } = BaseCapacity;
        public IReadOnlyDictionary<Guid, uint> ToolsCapacity { get; } =  ToolsCapacity;
        public Tool? ChosenTool { get; set; } = null;

        public override int Efficiency => BaseEfficiency;
    }
}