using System;

namespace Domain.FlattenDtos
{
    public record RiskDto(
        Guid Id,
        string Name,
        string PathToIcon,
        string Description,
        string HappenedMessage,
        string BadInfluenceMessage,
        Guid NeutralizerId,
        Guid LocationId)
    {
        public Guid Id { get; set; } = Id;
        
        public string Name {get; set;} = Name;
        public string PathToIcon { get; set; } = PathToIcon;
        public string Description { get; set; } = Description;
        
        public string HappenedMessage {get; set;} = HappenedMessage;

        public string BadInfluenceMessage {get; set;} = BadInfluenceMessage;
        public Guid NeutralizerId { get; set; } = NeutralizerId;
        public Guid LocationId { get; set; } = LocationId;
    }
}