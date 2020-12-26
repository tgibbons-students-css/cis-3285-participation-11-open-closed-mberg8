using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader 
{
    class Program
    {
        static void Main(string[] args)
        {
            var tradeStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VirtualTrader.trades4.txt");

            TradeProcessor tradeProcessor = new TradeProcessorVersion2();
            //TradeProcessor tradeProcessor2 = new TradeProcessorVersion2();

            // ============= do not change anything below this line =============
            tradeProcessor.ProcessTrades(tradeStream);

            Console.ReadKey();
        }
    }
}
