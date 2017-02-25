using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class VegBurger:Burger
    {
        public VegBurger()
        {
            Name = "Veg Burger";
            Price = 25;
        }

        public override string Name { get; }
        public override decimal Price { get; }
    }
}
