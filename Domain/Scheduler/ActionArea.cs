using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Domain.Scheduler
{
    public record ActionArea
    {
        public ActionArea(Guid id, string pathToTexture, string name, Location[] locations)
        {
            Id = id;
            PathToTexture = pathToTexture;
            Name = name;
            Locations = locations;

            foreach (var location in Locations) LocationsDictionary.Add(location.Id, location);
        }

        public Guid Id { get; }
        public string PathToTexture { get; set; }
        public string Name { get; set; }
        public Location[] Locations { get; set; }
        
        [JsonIgnore]
        public Dictionary<Guid, Location> LocationsDictionary { get; set; } = new();
        
        public Location GetLocationById(Guid id) => LocationsDictionary[id];

        public GameTask[] GetAllTasks()
        {
            var answer = new List<GameTask>();
            foreach (var location in Locations) answer.AddRange(location.Tasks);
            return answer.ToArray();
        }

        public void Reset()
        { 
            foreach (var location in Locations)
                foreach (var task in location.Tasks)
                    task.Reset();
        }

        public void Deconstruct(out Guid Id, out string PathToTexture, out string Name, out Location[] Locations)
        {
            Id = this.Id;
            PathToTexture = this.PathToTexture;
            Name = this.Name;
            Locations = this.Locations;
        }
    }
}