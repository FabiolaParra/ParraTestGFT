using System;
using System.Collections.Generic;

namespace ParraTestGFT
{
    class Program
    {
        static List<Trade> listTrades = new List<Trade>();
        static void Main(string[] args)
        {
            RankingTrade rank = new RankingTrade();
            listTrades.Add(new Trade(2000000, ClientSector.Private));
            listTrades.Add(new Trade(400000, ClientSector.Public));
            listTrades.Add(new Trade(500000, ClientSector.Public));
            listTrades.Add(new Trade(3000000, ClientSector.Public));

            foreach (Trade trade in listTrades)
            {                
                rank.ToDoRanking(trade);
            }

            Console.ReadLine();
        }
    }
}
