using System;

namespace FactoryPatternDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var shape1 = ShapeFactory.GetShape("CIRCLE");
            shape1.Draw();
            
            var shape2 = ShapeFactory.GetShape("RECTANGLE");
            shape2.Draw();
            
            var shape3 = ShapeFactory.GetShape("SQUARE");
            shape3.Draw();

            Console.ReadKey();
        }
    }
}
