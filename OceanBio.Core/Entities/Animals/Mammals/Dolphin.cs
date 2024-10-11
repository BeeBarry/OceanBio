using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Mammals
{
    public class Dolphin : Mammal
    {
        public string Echolocation { get; set; }
        public int PodSize { get; set; }
        public string DistinctiveFeatures { get; set; }
    }
}