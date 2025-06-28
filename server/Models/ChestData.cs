using System.Collections.Generic;

namespace Server.Models
{
   

    public static class ChestData
    {
        public static readonly Dictionary<string, Chest> Chests = new Dictionary<string, Chest>
        {
            // Gold chests
            { "Narkasseth fantastique",
                new Chest
                {
                    DisplayName = "Narkasseth fantastique",
                    Stage = "Etage 230–269 (Fantastique)",
                    ImagePath = "assets/gold_small.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite prasine", Probability = 0.43, Category = "prasine" },
                        new ChestOutcome { Name = "5 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 5 },
                        new ChestOutcome { Name = "10 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 10 },
                        new ChestOutcome { Name = "Rune astrale moyenne", Probability = 0.07, Category = "moyenne" },
                        new ChestOutcome { Name = "50 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 50 }
                    }
                }
            },
            { "Narkofret fantastique",
                new Chest
                {
                    DisplayName = "Narkofret fantastique",
                    Stage = "Etage 230–269 (Fantastique)",
                    ImagePath = "assets/gold_medium.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite emeraude", Probability = 0.42, Category = "emeraude" },
                        new ChestOutcome { Name = "15 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 15 },
                        new ChestOutcome { Name = "30 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 30 },
                        new ChestOutcome { Name = "Rune astrale majeure", Probability = 0.07, Category = "majeure" },
                        new ChestOutcome { Name = "150 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 150 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.01, Category = "elixir" }
                    }
                }
            },
            { "Narkès fantastique",
                new Chest
                {
                    DisplayName = "Narkès fantastique",
                    Stage = "Etage 230–269 (Fantastique)",
                    ImagePath = "assets/gold_large.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite sapin", Probability = 0.382, Category = "sapin" },
                        new ChestOutcome { Name = "30 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 30 },
                        new ChestOutcome { Name = "60 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 60 },
                        new ChestOutcome { Name = "Rune astrale épatante", Probability = 0.06, Category = "epatante" },
                        new ChestOutcome { Name = "300 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 300 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende ani. de Kwakarticho", Probability = 0.005, Category = "kwakarticho" },
                        new ChestOutcome { Name = "Légende de Buhorado", Probability = 0.0015, Category = "buhorado" },
                        new ChestOutcome { Name = "Légende de Cul Botté", Probability = 0.0015, Category = "cul" }
                    }
                }
            },
            // Blue chests
            { "Narkasseth imaginaire",
                new Chest
                {
                    DisplayName = "Narkasseth imaginaire",
                    Stage = "Etage 270–323 (Imaginaire)",
                    ImagePath = "assets/blue_small.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite cyan", Probability = 0.42, Category = "cyan" },
                        new ChestOutcome { Name = "15 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 15 },
                        new ChestOutcome { Name = "30 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 30 },
                        new ChestOutcome { Name = "Rune astrale majeure", Probability = 0.07, Category = "majeure" },
                        new ChestOutcome { Name = "150 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 150 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.01, Category = "elixir" }
                    }
                }
            },
            { "Narkofret imaginaire",
                new Chest
                {
                    DisplayName = "Narkofret imaginaire",
                    Stage = "Etage 270–323 (Imaginaire)",
                    ImagePath = "assets/blue_medium.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite azurée", Probability = 0.382, Category = "azuree" },
                        new ChestOutcome { Name = "30 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 30 },
                        new ChestOutcome { Name = "60 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 60 },
                        new ChestOutcome { Name = "Rune astrale épatante", Probability = 0.06, Category = "epatante" },
                        new ChestOutcome { Name = "300 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 300 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende ani. de Magicrabe", Probability = 0.005, Category = "magicrabe" },
                        new ChestOutcome { Name = "Légende de Dame Jessica", Probability = 0.0015, Category = "jhess" },
                        new ChestOutcome { Name = "Légende de Mille Lieues", Probability = 0.0015, Category = "mille" }
                    }
                }
            },
            { "Narkès imaginaire",
                new Chest
                {
                    DisplayName = "Narkès imaginaire",
                    Stage = "Etage 270–323 (Imaginaire)",
                    ImagePath = "assets/blue_large.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite safre", Probability = 0.3805, Category = "safre" },
                        new ChestOutcome { Name = "100 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 100 },
                        new ChestOutcome { Name = "200 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 200 },
                        new ChestOutcome { Name = "Rune astrale merveilleuse", Probability = 0.06, Category = "merveilleuse" },
                        new ChestOutcome { Name = "1000 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 1000 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende ani. de Bakushana", Probability = 0.005, Category = "bakushana" },
                        new ChestOutcome { Name = "Légende de Fallanster", Probability = 0.0015, Category = "fallanster" },
                        new ChestOutcome { Name = "Légende de Ganymède", Probability = 0.0015, Category = "ganymede" },
                        new ChestOutcome { Name = "Légende de Misère", Probability = 0.0015, Category = "misere" }
                    }
                }
            },
            // Purple chests
            { "Narkasseth brumeux",
                new Chest
                {
                    DisplayName = "Narkasseth brumeux",
                    Stage = "Etage 324+ (Brumeux)",
                    ImagePath = "assets/purple_small.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite parme", Probability = 0.3855, Category = "parme" },
                        new ChestOutcome { Name = "30 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 30 },
                        new ChestOutcome { Name = "60 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 60 },
                        new ChestOutcome { Name = "Rune astrale épatante", Probability = 0.06, Category = "epatante" },
                        new ChestOutcome { Name = "300 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 300 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende de Brâm Barbe-Monde", Probability = 0.0015, Category = "bram" },
                        new ChestOutcome { Name = "Légende de Dodge", Probability = 0.0015, Category = "dodge" },
                        new ChestOutcome { Name = "Légende de Guerre", Probability = 0.0015, Category = "guerre" }
                    }
                }
            },
            { "Narkofret brumeux",
                new Chest
                {
                    DisplayName = "Narkofret brumeux",
                    Stage = "Etage 324+ (Brumeux)",
                    ImagePath = "assets/purple_medium.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite indigo", Probability = 0.3805, Category = "indigo" },
                        new ChestOutcome { Name = "100 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 100 },
                        new ChestOutcome { Name = "200 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 200 },
                        new ChestOutcome { Name = "Rune astrale merveilleuse", Probability = 0.06, Category = "merveilleuse" },
                        new ChestOutcome { Name = "1000 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 1000 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende ani. de Poukachi", Probability = 0.005, Category = "poukachi" },
                        new ChestOutcome { Name = "Légende de Crocobur", Probability = 0.0015, Category = "crocobur" },
                        new ChestOutcome { Name = "Légende de Trompe-la-Mort", Probability = 0.0015, Category = "trompe" },
                        new ChestOutcome { Name = "Légende de Corruption", Probability = 0.0015, Category = "corruption" }
                    }
                }
            },
            { "Narkès brumeux",
                new Chest
                {
                    DisplayName = "Narkès brumeux",
                    Stage = "Etage 324+ (Brumeux)",
                    ImagePath = "assets/purple_large.png",
                    Outcomes = new List<ChestOutcome>
                    {
                        new ChestOutcome { Name = "Prysmaradite zinzolin", Probability = 0.3805, Category = "zinzolin" },
                        new ChestOutcome { Name = "250 Reflets oniriques", Probability = 0.30, Category = "reflets", Quantity = 250 },
                        new ChestOutcome { Name = "500 Reflets oniriques", Probability = 0.15, Category = "reflets", Quantity = 500 },
                        new ChestOutcome { Name = "Rune astrale légendaire", Probability = 0.06, Category = "legendaire" },
                        new ChestOutcome { Name = "2500 Reflets oniriques", Probability = 0.05, Category = "reflets", Quantity = 2500 },
                        new ChestOutcome { Name = "Élixir uchronique", Probability = 0.05, Category = "elixir" },
                        new ChestOutcome { Name = "Légende ani. de Bébémoth", Probability = 0.005, Category = "bebemoth" },
                        new ChestOutcome { Name = "Légende de Jahash Jurgen", Probability = 0.0015, Category = "jahash" },
                        new ChestOutcome { Name = "Légende de Rykke-Errel", Probability = 0.0015, Category = "rykke" },
                        new ChestOutcome { Name = "Légende de Servitude", Probability = 0.0015, Category = "servitude" }
                    }
                }
            }
        };
    }
}
