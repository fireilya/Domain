using System;
using Domain.Enumerations;

namespace Domain.FlattenDtos
{
    public record EdgeDto(Guid Id, Guid Node1Id, Guid Node2Id, EdgeType EdgeType)
    {
        public Guid Id { get; set; } = Id;
        public Guid Node1Id { get; set; } = Node1Id;
        public Guid Node2Id { get; set; } = Node2Id;
        public EdgeType EdgeType { get; set; } = EdgeType;
    }
}