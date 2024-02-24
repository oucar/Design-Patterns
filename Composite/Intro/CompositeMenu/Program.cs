﻿namespace Composite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
            MenuComponent coffeeMenu = new Menu("COFFEE MENU", "Stuff to go with your afternoon coffee");

            MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99m));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99m));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49m));
            pancakeHouseMenu.Add(new MenuItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59m));

            dinerMenu.Add(new MenuItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99m));
            dinerMenu.Add(new MenuItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99m));
            dinerMenu.Add(new MenuItem("Soup of the day", "A bowl of the soup of the day, with a side of potato salad", false, 3.29m));
            dinerMenu.Add(new MenuItem("Hotdog", "A hot dog, with sauerkraut, relish, onions, topped with cheese", false, 3.05m));
            dinerMenu.Add(new MenuItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", true, 3.99m));
            dinerMenu.Add(new MenuItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89m));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem("Apple Pie", "Apple pie with a flakey crust, topped with vanilla icecream", true, 1.59m));
            dessertMenu.Add(new MenuItem("Cheesecake", "Creamy New York cheesecake, with a chocolate graham crust", true, 1.99m));
            dessertMenu.Add(new MenuItem("Sorbet", "A scoop of raspberry and a scoop of lime", true, 1.89m));

            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99m));
            cafeMenu.Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69m));
            cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29m));

            cafeMenu.Add(coffeeMenu);

            coffeeMenu.Add(new MenuItem("Coffee Cake", "Crumbly cake topped with cinnamon and walnuts", true, 1.59m));
            coffeeMenu.Add(new MenuItem("Bagel", "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin", false, 0.69m));
            coffeeMenu.Add(new MenuItem("Biscotti", "Three almond or hazelnut biscotti cookies", true, 0.89m));

            Waitress waitress = new Waitress(allMenus);

            waitress.PrintMenu();
        }

    }
}