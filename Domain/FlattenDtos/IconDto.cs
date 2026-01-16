namespace Domain.FlattenDtos
{
    public record IconDto(
        string Path,
        byte[] Body
    )
    {
        public string Path { get; set; } = Path;
        public byte[] Body { get; set; } = Body;
    }
}