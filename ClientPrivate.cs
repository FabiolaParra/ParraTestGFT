using System;
using System.Collections.Generic;
using System.Text;
using static ParraTestGFT.Rank;

namespace ParraTestGFT
{
    public class ClientPrivate : iTrade
    {
        public void ToDoTrade(Trade trade)
        {
            if (trade.Value > 1000000)
            {
                trade.TradeCategories = Trade.eTradeCategories.HIGHRISK;
            }
            else trade.TradeCategories = Trade.eTradeCategories.NOT_APPLICABLE;
        }
    }
}

