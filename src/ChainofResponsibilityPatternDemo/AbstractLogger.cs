namespace ChainofResponsibilityPatternDemo
{
    public abstract class AbstractLogger
    {
        public static int Info = 1;
        public static int Debug = 2;
        public static int Error = 3;

        protected int Level;

        //责任链中的下一个元素
        protected AbstractLogger NextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            NextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (Level <= level)
                Write(message);
            NextLogger?.LogMessage(level, message);
        }

        protected abstract void Write(string message);
    }
}