namespace BuilderPatternDemo
{
    public abstract class MealItem
    {
        public abstract string Name { get; }

        public abstract decimal Price { get; }

        public abstract MealPacker Packer { get; }
    }
}