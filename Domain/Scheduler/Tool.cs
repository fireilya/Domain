namespace Domain.Scheduler
{
    public record Tool(string Name, string PathToIcon)
    {
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
    }
}