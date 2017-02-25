using System;

namespace AbstractFactoryPatternDemo
{
    public abstract class Trouser
    {
        public abstract void Print();
    }

public class Jeans : Trouser
{
    public override void Print()
    {
        Console.WriteLine("Jeans!");
    }
}

public class Shorts : Trouser
{
    public override void Print()
    {
        Console.WriteLine("Shorts!");
    }
}

public class Casual : Trouser
{
    public override void Print()
    {
        Console.WriteLine("Casual!");
    }
}
}