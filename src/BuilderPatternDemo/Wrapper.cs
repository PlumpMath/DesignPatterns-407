namespace BuilderPatternDemo
{
    public class Wrapper : MealPacker
    {
        public Wrapper()
        {
            Packer = "Wrapper";
        }

        public override string Packer { get; }
    }
}