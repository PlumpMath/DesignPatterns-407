using System;

namespace AbstractFactoryPatternDemo
{
public abstract class Coat
{
    public abstract void Print();
}

public class Jacket : Coat
{
    public override void Print()
    {
        Console.WriteLine("Jacket!");
    }
}

public class Shirt : Coat
{
    public override void Print()
    {
        Console.WriteLine("Shirt!");
    }
}

public class Sweater : Coat
{
    public override void Print()
    {
        Console.WriteLine("Sweater!");
    }
}
}