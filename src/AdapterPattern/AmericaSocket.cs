using System;

namespace AdapterPattern
{
    public class AmericaSocket
    {
        private readonly IAmericaStandardVoltage _americaStandardVoltage;

        public AmericaSocket(IAmericaStandardVoltage americaStandardVoltage)
        {
            _americaStandardVoltage = americaStandardVoltage;
        }

        public void Charge()
        {
            _americaStandardVoltage.PowerOn();
            Console.WriteLine("Charging Successfully");
        }
    }
}