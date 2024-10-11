using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Fish
{
    public class Stingray : Fish
    {
        public int NumberOfStings { get; set; }
        public string VenomType { get; set; }
        public bool CanProduceElectricity { get; set; }

        public Stingray()
        {
            Type = AnimalType.MARINE;
            IsCartilaginous = true;
        }
    }
}
