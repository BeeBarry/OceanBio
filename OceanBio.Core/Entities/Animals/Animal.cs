using System;
using System.Collections.Generic;

namespace OceanBio.Core.Entities.Animals;

    public class Animal
    {
        public int Id { get; set; }
        public AnimalType Type { get; set; }
        public string ScientificName { get; set; }
        public string CommonName { get; set; }
        public string Description { get; set; }
        public string ConservationStatus { get; set; }
        public double AverageSize { get; set; }
        public double AverageWeight { get; set; }
        public string Habitat { get; set; }
        public List<string> Diet { get; set; }
        public int AverageLifespan  { get; set; }
        public List<string> Behaviors { get; set; }
        public List<string> Threats { get; set; }
        public string EcologicalRole { get; set; }
        public List<string> InterestingTrivia { get; set; }
        public int MaxDivingDepth { get; set; }
        public string OceanRegion { get; set; }
        public List<string> OceanLayers { get; set; }

        public string GetInfo()
        {
            return $"Common name: {CommonName}\n" +
                   $"Scientific name: {ScientificName}\n" +
                   $"Type: {Type}\n" +
                   $"Description: {Description}\n" +
                   $"Conservation Status: {ConservationStatus}\n" +
                   $"Average Size: {AverageSize} m\n" +
                   $"Average Weight: {AverageWeight} kg\n" +
                   $"Habitat: {Habitat}\n" +
                   $"Diet: {string.Join(", ", Diet)}\n" +
                   $"Average Lifespan: {AverageLifespan} years\n" +
                   $"Ecological Role: {EcologicalRole}\n" +
                   $"Max Diving Depth: {MaxDivingDepth} m\n" +
                   $"Ocean Region: {OceanRegion}\n" +
                   $"Ocean Layers: {string.Join(", ", OceanLayers)}";
        }

        public string GetRandomTrivia()
        {
            if (InterestingTrivia == null || InterestingTrivia.Count == 0)
            {
                return "No trivia available for this animal.";
            }

            Random random = new Random();
            int index = random.Next(InterestingTrivia.Count);
            return InterestingTrivia[index];
        }
        
        
    }
    
    

