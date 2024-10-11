using OceanBio.Core.Entities;

namespace OceanBio.Core.Entities.Animals.Mammals
{
    public class Whale : Mammal
    {
        public string WhaleType { get; set; }
        public int MaxDivingDepth { get; set; }
        public string SongPattern { get; set; }

        public Whale()
        {
            Type = AnimalType.MARINE;
        }
    }
}