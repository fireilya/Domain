namespace Domain.FlattenDtos
{
    public record IconDto(
        string Id,
        byte[] Body
    )
    {
        public string Id { get; set; } = Id;
        public byte[] Body { get; set; } = Body;
    }
}