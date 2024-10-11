using System.Collections.Generic;

namespace OceanBio.Core.Entities.Animals.Fish;

public class Fish : Animal
{
        public List<string> FinTypes { get; set; }
        public bool IsCartilaginous { get; set; }
}