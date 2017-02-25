namespace AbstractFactoryPatternDemo.Factory
{
public class FirstChestFactory : AbstractFactory
{
    public override Coat CreateCoat()
    {
        return new Jacket();
    }

    public override Trouser CreateTrouser()
    {
        return new Jeans();
    }
}
}