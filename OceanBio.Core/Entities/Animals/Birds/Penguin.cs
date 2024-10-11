using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Birds
{
    public class Penguin : Bird
    {
        public string SpeciesType { get; set; }
        public int DivingDepth { get; set; }
        public string ColonyLocation { get; set; }

        public Penguin()
        {
            Type = AnimalType.MARINE;
        }
    }
}
