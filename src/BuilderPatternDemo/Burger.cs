namespace BuilderPatternDemo
{
    public abstract class Burger : MealItem
    {
        public override MealPacker Packer => new Wrapper();
    }
}