namespace BridgePatternDemo
{
    public abstract class Shape
    {
        protected readonly IDrawAPI DrawApi;

        protected Shape(IDrawAPI drawApi)
        {
            DrawApi = drawApi;
        }

        public abstract void Draw();
    }
}