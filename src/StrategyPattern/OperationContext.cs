namespace StrategyPattern
{
    public class OperationContext
    {
        private readonly IStrategy _strategy;

        public OperationContext(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public int ExecuteStrategy(int num1, int num2)
        {
            return _strategy.DoOperation(num1, num2);
        }
    }
}