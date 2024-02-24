using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    // Single Tag - building block of Html
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();
        private const int indentSize = 2;

        // Constructor(s)
        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        // Customizing the StringBuilder()
        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);

            sb.Append($"{i}<{Name}>\n");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            // Getting the nested indentation
            foreach (var e in Elements)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }

            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    // Builder for the HTML elements
    public class HtmlBuilder
    {
        private readonly string rootName;
        public HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;

        }

        // Fluent Interface - returning the instance of the builder
        // So that it allows chaining of the methods
        public HtmlBuilder AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public void PrintChildren()
        {
            for (int i = 0; i < root.Elements.Count; i++)
            {
                Console.Write($"{i + 1} - {root.Elements[i]}");
            }
        }

        public override string ToString()
        {
            return root.ToString();
        }

        // The root is stateful
        public void Clear()
        {
            root = new HtmlElement { Name = rootName };
        }
    }
}
