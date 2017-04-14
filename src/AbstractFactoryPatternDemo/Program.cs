using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactoryPatternDemo.Factory;

namespace AbstractFactoryPatternDemo
{
    public class Program
    {
public static void Main(string[] args)
{
    AbstractFactory abstractFactory=new FirstChestFactory();
    abstractFactory.CreateCoat().Print();
    abstractFactory.CreateTrouser().Print();

    abstractFactory=new SecondChestFactory();
    abstractFactory.CreateCoat().Print();
    abstractFactory.CreateTrouser().Print();

    abstractFactory=new ThirdChestFactory();
    abstractFactory.CreateCoat().Print();
    abstractFactory.CreateTrouser().Print();
}
    }
}
