using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Fish
{
    public class Shark : Fish
    {
        public int NumberOfTeeth { get; set; }
        public string SharkType { get; set; }  // e.g., "Great White", "Hammerhead", etc.
        public bool IsEndangered { get; set; }

        public Shark()
        {
            Type = AnimalType.MARINE;
            IsCartilaginous = true;
        }
    }
}