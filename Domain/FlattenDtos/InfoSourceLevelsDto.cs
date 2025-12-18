namespace Domain.FlattenDtos
{
    public record InfoSourceLevelDto(int Id, short InteractTimeInMinute)
    {
        public int Id { get; set; } = Id;
        public short InteractTimeInMinute { get; set; } = InteractTimeInMinute;
    }
}