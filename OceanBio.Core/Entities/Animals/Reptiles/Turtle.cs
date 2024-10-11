using OceanBio.Core.Entities;
using OceanBio.Core.Entities.Animals;

namespace OceanBio.Core.Entities.Animals.Reptiles
{
    public class Turtle : Reptile
    {
        public string ShellType { get; set; }
        public int AgeAtMaturity { get; set; }
        public string NestingBeach { get; set; }

        public Turtle()
        {
            Type = AnimalType.MARINE;
        }
    }
}