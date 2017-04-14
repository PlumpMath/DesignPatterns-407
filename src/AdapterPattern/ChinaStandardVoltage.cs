using System;

namespace AdapterPattern
{
    public class ChinaStandardVoltage : IChinaStandardVoltage
    {
        public void PowerOn()
        {
            Console.WriteLine("Voltage: 220V");
        }
    }
}