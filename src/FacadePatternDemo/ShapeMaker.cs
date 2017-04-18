namespace FacadePatternDemo
{
    public class ShapeMaker
    {
        private readonly IShape _circle = new Circle();
        private readonly IShape _rectangle = new Rectangle();
        private readonly IShape _square = new Square();

        public void DrawCircle()
        {
            _circle.Draw();
        }

        public void DrawRectangle()
        {
            _rectangle.Draw();
        }

        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}