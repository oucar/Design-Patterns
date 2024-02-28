namespace DesignPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Simple Factory
            var simpleFactoryNavigationBar = new SFNavigationBar();
            var simpleFactoryDropdownMenu = new SFDropdownMenu();
            Console.WriteLine($"{simpleFactoryNavigationBar.Button.Type} - {simpleFactoryNavigationBar.Type}");
            Console.WriteLine($"{simpleFactoryDropdownMenu.Button.Type} - {simpleFactoryDropdownMenu.Type}");

            // Abstract Factory
            var abstractFactoryAppleNavigationBar = new AFNavigationBar(new Apple());
            var abstractFactoryAppleDropdownMenu = new AFDropdownMenu(new Apple());
            var abstractFactoryAndroidDropdownMenu = new AFDropdownMenu(new Android());
            var abstractFactoryAndroidNavigationBar = new AFNavigationBar(new Android());
            Console.WriteLine($"{abstractFactoryAppleNavigationBar.AFButton.Type} - {abstractFactoryAppleNavigationBar.Type}");
            Console.WriteLine($"{abstractFactoryAppleDropdownMenu.AFButton.Type} - {abstractFactoryAppleDropdownMenu.Type}");
            Console.WriteLine($"{abstractFactoryAndroidNavigationBar.AFButton.Type} - {abstractFactoryAndroidNavigationBar.Type}");
            Console.WriteLine($"{abstractFactoryAndroidDropdownMenu.AFButton.Type} - {abstractFactoryAndroidDropdownMenu.Type}");

            // Factory Method
            Button navButton = new NavigationBar().CreateButton();
            Button dropdownButton = new DropdownMenu().CreateButton();
            Button androidNavButton = new AndroidNavigationBar().CreateButton();
            Button androidDropdownButton = new AndroidDropdownMenu().CreateButton();

            Console.WriteLine($"Created button: {navButton.Type}");
            Console.WriteLine($"Created button: {dropdownButton.Type}");
            Console.WriteLine($"Created button: {androidNavButton.Type}");
            Console.WriteLine($"Created button: {androidDropdownButton.Type}");


        }
    }
}
