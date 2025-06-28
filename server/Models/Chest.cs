using System.Collections.Generic;
namespace Server.Models
{
    public class Chest
    {
        public string DisplayName { get; set; } = string.Empty;
        public string Stage { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public List<ChestOutcome> Outcomes { get; set; } = new List<ChestOutcome>();

    }
}