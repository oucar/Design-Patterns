using System;

namespace DesignPatterns
{
    // Represents a simple button with a type property.
    public class Button
    {
        public string? Type { get; set; }
    }

    // Represents an abstract class for creating elements.
    public abstract class Element
    {
        // Forces derived classes to implement a method for creating buttons.
        public abstract Button CreateButton();
    }

    // Represents a navigation bar element that creates a default navigation button.
    public class NavigationBar : Element
    {
        // Creates a default navigation button.
        public override Button CreateButton()
        {
            return new Button { Type = "Default Navigation Button" };
        }
    }

    // Represents a dropdown menu element that creates a default dropdown button.
    public class DropdownMenu : Element
    {
        // Creates a default dropdown button.
        public override Button CreateButton()
        {
            return new Button { Type = "Default Dropdown Button" };
        }
    }

    // Represents an Android navigation bar element that creates an Android-specific navigation button.
    public class AndroidNavigationBar : Element
    {
        // Creates an Android-specific navigation button.
        public override Button CreateButton()
        {
            return new Button { Type = "Android Navigation Button" };
        }
    }

    // Represents an Android dropdown menu element that creates an Android-specific dropdown button.
    public class AndroidDropdownMenu : Element
    {
        // Creates an Android-specific dropdown button.
        public override Button CreateButton()
        {
            return new Button { Type = "Android Dropdown Button" };
        }
    }
}
