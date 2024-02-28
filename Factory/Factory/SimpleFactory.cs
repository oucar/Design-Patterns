namespace DesignPatterns
{
    public class SFButton
    {
        public string ?Type { get; set; }
    }

    // Factory that is responsible for creating Buttons
    public class ButtonFactory
    {
        public static SFButton CreateButton()
        {
            return new SFButton { Type = "Simple Button by Simple Factory" };
        }
    }

    public class SFNavigationBar
    {
        public string Type { get; set; } = "Navigation Bar";
        public SFButton Button { get; set; }

        public SFNavigationBar()
        {
            Button = ButtonFactory.CreateButton();
        }
    }

    public class SFDropdownMenu
    {
        public string Type { get; set; } = "Dropdown Menu";
        public SFButton Button { get; set; }

        public SFDropdownMenu()
        {
            Button = ButtonFactory.CreateButton();
        }
    }
}
