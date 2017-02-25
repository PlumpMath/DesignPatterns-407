using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class ChickenBurger:Burger
    {
        public ChickenBurger()
        {
            Name = "Chicken Burger";
            Price = 50;
        }

        public override string Name { get; }
        public override decimal Price { get; }
    }
}
