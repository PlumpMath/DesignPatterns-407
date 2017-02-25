namespace BuilderPatternDemo
{
    public class Bottle : MealPacker
    {
        public Bottle()
        {
            Packer = "Bottle";
        }

        public override string Packer { get; }
    }
}