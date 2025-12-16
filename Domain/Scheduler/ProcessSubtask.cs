using System;

namespace Domain.Scheduler
{
    public record ProcessSubtask(string Name, uint BaseEfficiency, Tool NeededTool) :
        Subtask(Name, BaseEfficiency)
    {
        public double WorkCoeff => (ChosenTool != NeededTool ? 0.5 : 1.0);
        public Tool NeededTool { get; } = NeededTool;
        public Tool? ChosenTool { get; set; } = null;
        public override uint Efficiency => (uint)(BaseEfficiency * WorkCoeff);
    }
}