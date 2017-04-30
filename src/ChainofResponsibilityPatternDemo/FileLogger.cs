using System;

namespace ChainofResponsibilityPatternDemo
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            Level = level;
        }

        protected override void Write(string message)
        {
            Console.WriteLine("File::Logger: " + message);
        }
    }
}