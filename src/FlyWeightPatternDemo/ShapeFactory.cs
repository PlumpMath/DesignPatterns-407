using System;
using System.Collections.Generic;

namespace FlyWeightPatternDemo
{
    public class ShapeFactory
    {
        private static readonly Dictionary<string, IShape> CircleMap
            = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            if (CircleMap.ContainsKey(color))
            {
                return CircleMap[color];
            }
            
            var circle=new Circle(color);
            CircleMap.Add(color, circle);

            Console.WriteLine("Creating circle of color : " + color);
            return new Circle(color);
        }
    }
}