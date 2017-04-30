using System;

namespace ProxyPatternDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //图像将从磁盘加载
            image.Display();
            Console.WriteLine("");
            //图像将无法从磁盘加载
            image.Display();
        }
    }
}