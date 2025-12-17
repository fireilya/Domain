using System;

namespace Domain.Scheduler
{
    public record ProcessSubtask(Guid Id, string Name, int BaseEfficiency, Tool NeededTool) :
        Subtask(Id, Name, BaseEfficiency)
    {
        public double WorkCoeff => (ChosenTool != NeededTool ? 0.5 : 1.0);
        public Tool NeededTool { get; } = NeededTool;
        public Tool? ChosenTool { get; set; } = null;
        public override int Efficiency => (int)(BaseEfficiency * WorkCoeff);
    }
}