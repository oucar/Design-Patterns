using System;

namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // simple seed prototyping
            var garden = new GardenFactory(
                new TreeSeed("Apple"),
                new GrassSeed("Red"),
                new FlowerSeed("Roses")
            );

            var plant1 = garden.CreatePlant1();
            var plant2 = garden.CreatePlant2();
            var plant3 = garden.CreatePlant3();

            Console.WriteLine($"Plant 1 type: {plant1.GetType().Name}");
            Console.WriteLine($"Plant 2 type: {plant2.GetType().Name}");
            Console.WriteLine($"Plant 3 type: {plant3.GetType().Name}");

            // "excel"
            List<IBlock> grid = new List<IBlock>();
            grid.Add(BlockFactory.Create("Hello World"));
            grid.Add(BlockFactory.Create("3"));
            grid.Add(BlockFactory.Create("11/02/1980"));

            var block3 = (DateTimeBlock)grid[2].Clone();
            block3.Format = "MM/dd/yyyy";
            grid.Add(block3);

            var block4 = (DateTimeBlock)grid[3].Clone();
            block4.DateTime = DateTime.UtcNow;
            grid.Add(block4);

            // Print out the rendered content of each block
            foreach (var block in grid)
            {
                Console.WriteLine(block.Render);
            }



        }
    }
}
