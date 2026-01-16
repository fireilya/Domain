using System;
using System.Text;

namespace Domain.Scheduler
{
    public record Risk(
        Guid Id,
        string Name,
        string PathToIcon,
        string Description,
        string HappenedMessage,
        string BadInfluenceMessage,
        Guid NeutralizerID)
    {
        public Guid Id { get; } = Id;
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
        public string Description { get; } = Description;
        public string HappenedMessage { get; } = HappenedMessage;
        public string BadInfluenceMessage { get; } = BadInfluenceMessage;
        public double Chance { get; } = 1.0;
        
        public float SlowingCoeff { get; } = 0.8f;
        
        public Guid NeutralizerID { get; } = NeutralizerID;
        
        public bool IsRightNeutralizer(Guid neutralizerID) => NeutralizerID.Equals(neutralizerID);

        public bool TryRiskHappened(Guid chosenNeutraliserID, out float influenceCoeff)
        {
            var isHappened = _random.NextDouble() < Chance;
            influenceCoeff = isHappened && !IsRightNeutralizer(chosenNeutraliserID) ? SlowingCoeff : 1.0f;
            return isHappened;
        }
            

        private readonly Random _random = new();
    }
}