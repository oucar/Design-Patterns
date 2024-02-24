﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool vegetarian, decimal price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarian;
            Price = price;
        }

        public override string Name { get; }
        public override string Description { get; }
        public override bool IsVegetarian { get; }
        public override decimal Price { get; }

        public override void Print()
        {
            Console.Write(" " + Name);
            if (IsVegetarian)
            {
                Console.Write("(v)");
            }
            Console.WriteLine(", " + Price.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("    --" + Description);
        }
    }
}
