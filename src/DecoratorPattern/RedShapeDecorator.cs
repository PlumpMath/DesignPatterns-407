using System;

namespace DecoratorPattern
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(Shape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            base.Draw();

            SetRedBorder();
        }

        public void SetRedBorder()
        {
            Console.WriteLine("Border Color: Red");
        }
    }
}