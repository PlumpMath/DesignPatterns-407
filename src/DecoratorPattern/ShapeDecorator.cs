namespace DecoratorPattern
{
    public abstract class ShapeDecorator : Shape
    {
        private readonly Shape _shape;

        protected ShapeDecorator(Shape shape)
        {
            _shape = shape;
        }

        public override void Draw()
        {
            _shape.Draw();
        }
    }
}