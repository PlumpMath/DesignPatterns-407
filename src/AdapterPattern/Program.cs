using System.Linq.Expressions;

namespace AdapterPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IChinaStandardVoltage chinaStandardVoltage=new ChinaStandardVoltage();
            StandardVoltageAdapter adapter=new StandardVoltageAdapter(chinaStandardVoltage);

            AmericaSocket socket=new AmericaSocket(adapter);
            socket.Charge();
        }
    }
}