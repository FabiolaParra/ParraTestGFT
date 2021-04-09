using System;
using System.Collections.Generic;
using System.Text;


namespace ParraTestGFT
{
    public class RankingTrade
    {
        public void ToDoRanking(Trade trade)
        {
            if (trade.ClientSector.Equals(ClientSector.Public))
            {
                var rankingClientePublic = new RankingClientPublic();
                rankingClientePublic.ToDoRanking(trade);
                Console.WriteLine(trade.TradeCategories);
            }
            else if (trade.ClientSector.Equals(ClientSector.Private))
            {
                var rankingClientePrivate = new RankingClientPrivate();
                rankingClientePrivate.ToDoRanking(trade);
                Console.WriteLine(trade.TradeCategories);
            }
        }
    }
    
}
