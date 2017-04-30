using System;

namespace FlyWeightPatternDemo
{
    public class Circle : IShape
    {
        private readonly string _color;

        public Circle(string color)
        {
            _color = color;
        }

        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Circle: Draw() [Color : " + _color
                              + ", x : " + X + ", y :" + Y + ", radius :" + Radius);
        }
    }
}