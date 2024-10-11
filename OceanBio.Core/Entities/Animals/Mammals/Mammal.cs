using System.Collections.Generic;

namespace OceanBio.Core.Entities.Animals.Mammals;

public class Mammal : Animal
{
    public int GestationPeriod { get; set; }
    public int AverageOffspringCount { get; set; }
    public string SocialStructure { get; set; }
    public List<string> CommunicationMethods { get; set; }
}