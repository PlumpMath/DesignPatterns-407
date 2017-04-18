namespace BridgePatternDemo
{
    public class Circle : Shape
    {
        private readonly int _x;
        private readonly int _y;
        private readonly int _radius;

        public Circle(int x, int y, int radius, IDrawAPI drawApi) : base(drawApi)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public override void Draw()
        {
            DrawApi.DrawCircle(_x, _y, _radius);
        }
    }
}