namespace AbstractFactoryPatternDemo.Factory
{
public class SecondChestFactory : AbstractFactory
{
    public override Coat CreateCoat()
    {
        return new Shirt();
    }

    public override Trouser CreateTrouser()
    {
        return new Shorts();
    }
}
}