using OceanBio.Core.Entities;

namespace OceanBio.Core.Entities.Animals.Mammals
{
    public class Seal : Mammal
    {
        public string FurType { get; set; }
        public int BlubberThickness { get; set; }
        public string BreedingGrounds { get; set; }

        public Seal()
        {
            Type = AnimalType.MARINE;
        }
    }
}

