using System;
using System.Collections.Generic;
using System.Text;
using static ParraTestGFT.RankingTrade;

namespace ParraTestGFT
{
    public class RankingClientPrivate : ITrade
    {
        public void ToDoRanking(Trade trade)
        {
            if (trade.Value > 1000000)
            {
                trade.TradeCategories = TradeCategories.HighRisk;
            }
            else trade.TradeCategories = TradeCategories.NotApplicable;
        }
    }
}

