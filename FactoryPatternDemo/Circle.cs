﻿using System;

namespace FactoryPatternDemo
{
    public class Circle:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method");
        }
    }
}
