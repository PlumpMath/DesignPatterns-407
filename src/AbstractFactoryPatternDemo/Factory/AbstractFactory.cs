namespace AbstractFactoryPatternDemo.Factory
{
public abstract class AbstractFactory
{
    public abstract Coat CreateCoat();

    public abstract Trouser CreateTrouser();
}
}