using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPatternDemo
{
    public class Coke:ColdDrink
    {
        public Coke()
        {
            Name = "Coke";
            Price = 30;
        }

        public override string Name { get; }
        public override decimal Price { get; }
    }
}
