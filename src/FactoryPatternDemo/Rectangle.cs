using System;

namespace FactoryPatternDemo
{
    public class Rectangle:IShape
    {
        public void Draw()
        {
           Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
