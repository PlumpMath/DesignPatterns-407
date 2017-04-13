using System;

namespace FactoryPatternDemo
{
    public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method");
        }
    }
}
