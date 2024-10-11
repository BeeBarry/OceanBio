using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Fish
{
    public class Manta : Fish
    {
        public double WingSpan { get; set; }
        public string FilterFeedMethod { get; set; }
        public bool HasCephalicFins { get; set; }

        public Manta()
        {
            Type = AnimalType.MARINE;
            IsCartilaginous = true;
        }
        
    }
}