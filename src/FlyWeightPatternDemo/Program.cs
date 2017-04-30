using System;
using System.Collections.Generic;

namespace FlyWeightPatternDemo
{
    internal class Program
    {
        private static readonly List<string> Colors = new List<string>
        {
            "Red",
            "Green",
            "Blue",
            "White",
            "Black"
        };

        private  static readonly Random Random=new Random();

        private static void Main(string[] args)
        {
            for (var i = 0; i < 20; ++i)
            {
                var circle =
                    (Circle) ShapeFactory.GetCircle(GetRandomColor());
                circle.X = GetRandomX();
                circle.Y = GetRandomY();
                circle.Radius = 100;
                circle.Draw();
            }
        }

        private static string GetRandomColor()
        {
            return Colors[new Random().Next(0, Colors.Count - 1)];
        }

        private static int GetRandomX()
        {
            return Random.Next(0, 100);
        }

        private static int GetRandomY()
        {
            return Random.Next(0, 100);
        }
    }
}