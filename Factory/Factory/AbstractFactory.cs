namespace DesignPatterns
{
    // Button
    public class AFButton
    {
        public string? Type { get; set; }
    }

    // Abstract Factory Interface
    public interface IUIFactory
    {
        public AFButton CreateButton();
    }

    // Factory implementation for Apple
    public class Apple : IUIFactory
    {
        public AFButton CreateButton()
        {
            return new AFButton { Type = "iOS Button" };
        }
    }

    // Factory implementation for Android
    public class Android : IUIFactory
    {
        public AFButton CreateButton()
        {
            return new AFButton { Type = "Android Button" };
        }
    }

    // Navigation Bar
    public class AFNavigationBar
    {
        public string Type { get; set; } = "Navigation Bar";
        public AFButton AFButton { get; set; }

        public AFNavigationBar(IUIFactory factory)
        {
            AFButton = factory.CreateButton();
        }
    }

    // Dropdown Menu
    public class AFDropdownMenu
    {
        public string Type { get; set; } = "Dropdown Menu";
        public AFButton AFButton { get; set; }

        public AFDropdownMenu(IUIFactory factory)
        {
            AFButton = factory.CreateButton();
        }
    }
}
