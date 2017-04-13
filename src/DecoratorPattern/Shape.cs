using System;

namespace DecoratorPattern
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("I am a default shape");
        }
    }
}