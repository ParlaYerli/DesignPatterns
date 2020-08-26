﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Example2
{
    public class Car : ICarDecorator
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public Car()
        {
            Price = 10.6m;
        }

        public void AddDescription(string addedDesc)
        {
            Description = "Model:" + Model + "Brand:" + Brand + "Current Price:" + Price.ToString() + " " + addedDesc;
        }

        public void AddPrice(decimal addedPrice)
        {
            Price += addedPrice;
        }

        public void PrintDetail()
        {
            Console.WriteLine(Description);
        }
    }
}
