using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePatternDemo
{
   public class Square:IShape
    {
        public void Draw()
        {
            Console.WriteLine("Square::Draw()");
        }
    }
}
