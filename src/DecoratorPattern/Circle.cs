using System;

namespace DecoratorPattern
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am Circle");
        }
    }
}