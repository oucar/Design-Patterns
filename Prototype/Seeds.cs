using System;
namespace DesignPatterns
{
    // This class represents a factory for creating different types of plants (seeds)
    public class GardenFactory
    {
        Seed _seed1;
        Seed _seed2;
        Seed _seed3;

        public GardenFactory(
            Seed seed1,
            Seed seed2,
            Seed seed3
        )
        {
            _seed1 = seed1;
            _seed2 = seed2;
            _seed3 = seed3;
        }

        // Method to create copy of the plants.
        internal Seed CreatePlant1() => _seed1.Copy();
        internal Seed CreatePlant2() => _seed2.Copy();
        internal Seed CreatePlant3() => _seed3.Copy();
    }

    // Abstract method - each type of seed will implement its own
    public abstract class Seed
    {
        public abstract Seed Copy();
    }

    // Tree Seed
    public class TreeSeed : Seed
    {
        public string Type { get; }

        public TreeSeed(string type) => Type = type;

        public override Seed Copy() => new TreeSeed(Type);
    }

    // Grass Seed
    public class GrassSeed : Seed
    {
        public string Type { get; }

        public GrassSeed(string type) => Type = type;

        public override Seed Copy() => new GrassSeed(Type);
    }

    // Flower Seed
    public class FlowerSeed : Seed
    {
        public string Type { get; }

        public FlowerSeed(string type) => Type = type;

        public override Seed Copy() => new FlowerSeed(Type);
    }
}

