using Builder.Example4.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Example4.Model
{
    public class Pizza
    {
        public Size Size { get; set; }
        public Cheese Cheese { get; set; }
        public bool Sauce { get; set; }
        public bool Pepperoni { get; set; }
        public bool Ham { get; set; }
        public bool Olives { get; set; }
        public bool Mushrooms { get; set; }

        public Pizza(PizzaBuilder builder)
        {
            Size = builder.Size;
            Cheese = builder.Cheese;
            Sauce = builder.Sauce;
            Pepperoni = builder.Pepperoni;
            Ham = builder.Ham;
            Olives = builder.Olives;
            Mushrooms = builder.Mushrooms;
        }
    }

}
