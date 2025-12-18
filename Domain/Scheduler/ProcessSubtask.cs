using System;

namespace Domain.Scheduler
{
    public record ProcessSubtask(Guid Id, string Name, int BaseEfficiency, bool IsUseCapacityTool, Guid NeededToolId) :
        Subtask(Id, Name, BaseEfficiency, IsUseCapacityTool)
    {
        public double WorkCoeff => (ChosenTool != NeededToolId ? 0.5 : 1.0);
        public Guid NeededToolId { get; } = NeededToolId;
        public Guid? ChosenTool { get; set; } = null;
        public override int Efficiency => (int)(BaseEfficiency * WorkCoeff);
    }
}