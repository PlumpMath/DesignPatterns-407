using System;

namespace FacadePatternDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var shapeMaker = new ShapeMaker();

            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}