namespace FactoryPatternDemo
{
    public class ShapeFactory
    {
        public static IShape GetShape(string shapeType)
        {
            if (!string.IsNullOrWhiteSpace(shapeType))
            {
                if (shapeType.Equals("CIRCLE"))
                {
                    return new Circle();
                }
                if (shapeType.Equals("RECTANGLE"))
                {
                    return new Rectangle();
                }
                if (shapeType.Equals("SQUARE"))
                {
                    return new Square();
                }
            }

            return null;
        }
    }
}
