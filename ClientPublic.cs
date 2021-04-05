using System;
using System.Collections.Generic;
using System.Text;
using static ParraTestGFT.Rank;

namespace ParraTestGFT
{
    public class ClientPublic : iTrade
    {
        public void ToDoTrade(Trade trade)
        {
            if (trade.Value < 1000000)
            {
                trade.TradeCategories = Trade.eTradeCategories.LOWRISK;
            }
            else trade.TradeCategories = Trade.eTradeCategories.MEDIUMRISK;
        }
        
    }
}
