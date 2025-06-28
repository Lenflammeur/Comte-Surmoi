namespace Server.Models
{
    public class ChestOutcome
    {
        public string Name { get; set; } = string.Empty;
        public double Probability { get; set; }
        public string Category { get; set; } = string.Empty;
        public int Quantity { get; set; } = 1;
    }

}