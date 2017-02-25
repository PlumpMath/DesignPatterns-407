using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class Pepsi:ColdDrink
    {
        public Pepsi()
        {
            Name = "Pepsi";
            Price = 35;
        }

        public override string Name { get; }
        public override decimal Price { get; }
    }
}
