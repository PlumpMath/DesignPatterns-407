using System;

namespace IteratorPatternDemo
{
class Program
{
    static void Main(string[] args)
    {
        object[] values = {"a", "b", "c", "d", "e"};
        Iteration collection=new Iteration(values,3);
        foreach (var x in collection)
        {
            Console.WriteLine(x);
        }

        Console.ReadKey();
    }
}
}