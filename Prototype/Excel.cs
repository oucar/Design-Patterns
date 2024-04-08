using System;

namespace DesignPatterns
{
    // Factory class responsible for creating different types of blocks
    public class BlockFactory
    {
        // Method to create a block based on the provided content
        public static IBlock Create(string content)
        {
            // Attempt to parse the content as DateTime
            if (DateTime.TryParse(content, out var dt))
                return new DateTimeBlock()
                {
                    Format = "dd/MM/yyyy",
                    DateTime = dt
                };

            // Attempt to parse the content as an integer
            if (int.TryParse(content, out var n))
                return new NumberBlock() { Number = n };

            return new TextBlock { Content = content };
        }
    }

    // Interface representing common properties and behaviors of all block types
    public interface IBlock
    {
        // Render property to get the content of the block
        string Render { get; }
        // Clone method to create a copy of the block
        IBlock Clone(); 
    }

    // Concrete class representing a text block
    public class TextBlock : IBlock
    {
        public string Content { get; set; }

        public IBlock Clone() => new TextBlock { Content = Content };

        public string Render => Content;
    }

    // Concrete class representing a number block
    public class NumberBlock : IBlock
    {
        public int Number { get; set; } 

        public IBlock Clone() => new NumberBlock { Number = Number };

        public string Render => Number.ToString();
    }

    // Concrete class representing a date-time block
    public class DateTimeBlock : IBlock
    {
        public DateTime DateTime { get; set; } 
        public string Format { get; set; }

        public IBlock Clone() => new DateTimeBlock
        {
            Format = Format,
            DateTime = DateTime
        };

        public string Render => DateTime.ToString(Format);
    }
}
