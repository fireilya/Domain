namespace Domain.Scheduler
{
    public record Neutralizer(string Name, string PathToIcon)
    {
        public string Name { get; } = Name;
        public string PathToIcon { get; } = PathToIcon;
    }
}