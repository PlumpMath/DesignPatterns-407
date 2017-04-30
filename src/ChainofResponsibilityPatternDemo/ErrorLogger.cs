using System;

namespace ChainofResponsibilityPatternDemo
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            Level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }
}