using System;

namespace BridgePatternDemo
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: "
                              + radius + ", x: " + x + ", " + y + "]");
        }
    }
}