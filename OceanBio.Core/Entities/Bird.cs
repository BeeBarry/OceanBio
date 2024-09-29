using System.Collections.Generic;
namespace OceanBio.Core.Entities;

public class Bird : Animal
{
    public double Wingspan  { get; set; }
    public string NestingHabitat { get; set; }
    public List<string> FeedingTechniques { get; set; }
    public string MigrationPattern { get; set; }
}