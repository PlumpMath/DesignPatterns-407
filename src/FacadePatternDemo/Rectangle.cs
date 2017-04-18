using System;

namespace FacadePatternDemo
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle::Draw()");
        }
    }
}