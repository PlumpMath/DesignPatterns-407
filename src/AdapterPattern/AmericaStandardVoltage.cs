using System;

namespace AdapterPattern
{
    public class AmericaStandardVoltage : IAmericaStandardVoltage
    {
        public void PowerOn()
        {
            Console.WriteLine("Voltage: 110V");
        }
    }
}