using System;
using System.Collections.Generic;
using System.Text;

namespace ParraTestGFT
{
    public class Rank
    {
        public void ToDoTrade(Trade trade)
        {
            if (trade.ClientSector.Equals(Trade.eClientSector.Public))
            {
                var clientePublic = new ClientPublic();
                clientePublic.ToDoTrade(trade);
                Console.WriteLine(trade.TradeCategories);
            }
            else if (trade.ClientSector.Equals(Trade.eClientSector.Private))
            {
                var clientePrivate = new ClientPrivate();
                clientePrivate.ToDoTrade(trade);
                Console.WriteLine(trade.TradeCategories);
            }
        }
    }
    
}
