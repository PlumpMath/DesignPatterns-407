namespace BuilderPatternDemo
{
    public abstract class ColdDrink : MealItem
    {
        public override MealPacker Packer => new Bottle();
    }
}