namespace AdapterPattern
{
    public class StandardVoltageAdapter : IAmericaStandardVoltage
    {
        private readonly IChinaStandardVoltage _chinaStandardVoltage;

        public StandardVoltageAdapter(IChinaStandardVoltage chinaStandardVoltage)
        {
            _chinaStandardVoltage = chinaStandardVoltage;
        }

        public void PowerOn()
        {
            _chinaStandardVoltage.PowerOn();
        }
    }
}