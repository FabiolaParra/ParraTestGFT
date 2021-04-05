using System;
using System.Collections.Generic;

namespace ParraTestGFT
{
    class Program
    {
        static List<Trade> listTrades = new List<Trade>();
        static void Main(string[] args)
        {
            Rank rank = new Rank();
            listTrades.Add(new Trade(2000000, Trade.eClientSector.Private));
            listTrades.Add(new Trade(400000, Trade.eClientSector.Public));
            listTrades.Add(new Trade(500000, Trade.eClientSector.Public));
            listTrades.Add(new Trade(3000000, Trade.eClientSector.Public));

            foreach (Trade trade in listTrades)
            {                
                rank.ToDoTrade(trade);
            }

            Console.ReadLine();
        }
    }
}
