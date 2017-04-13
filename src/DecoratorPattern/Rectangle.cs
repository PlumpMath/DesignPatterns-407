﻿using System;

namespace DecoratorPattern
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}