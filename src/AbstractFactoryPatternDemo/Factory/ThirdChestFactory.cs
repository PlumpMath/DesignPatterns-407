namespace AbstractFactoryPatternDemo.Factory
{
public class ThirdChestFactory : AbstractFactory
{
    public override Coat CreateCoat()
    {
        return new Sweater();
    }

    public override Trouser CreateTrouser()
    {
        return new Casual();
    }
}
}