using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AbstractTrader
{
    public interface IProcessTrades 
    {
        protected abstract IEnumerable<string> ReadTradeData(Stream stream);

        protected abstract IEnumerable<TradeRecord> ParseTrades(IEnumerable<string> tradeData);


        protected abstract void StoreTrades(IEnumerable<TradeRecord> trades);

        public virtual void ProcessTrades(Stream stream)
        //public void ProcessTrades(string url)
        {
            var lines = ReadTradeData(stream);
            //var lines = ReadURLTradeData(url);
            var trades = ParseTrades(lines);
            StoreTrades(trades);
        }


    }
}
