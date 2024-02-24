namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Regular Builder - Builder.cs
            Console.WriteLine("### Builder Pattern Demo - Builder.cs ###");

            var builder = new HtmlBuilder("ul");
            builder.AddChild("li", "hello").AddChild("li", "world");

            Console.WriteLine(builder.ToString());
            builder.PrintChildren();

            // Mini App
            Console.WriteLine("\n\n### Car Builder - CarBuilder.cs ###");

            var carBuilder = new CarBuilder();
            carBuilder.setMake("lada").setColor("red").setManifactureDate(DateTime.UtcNow);
            carBuilder.CarDetails();

            // or with using the Build method
            Car car = carBuilder.Build();
            car.Honk();
        }
    }
}
