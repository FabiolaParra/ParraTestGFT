using System;
using System.Collections.Generic;
using System.Text;

namespace ParraTestGFT
{
    public class Trade
    {
        public eClientSector ClientSector { get; set; }
        public double Value { get; set; }
        public eTradeCategories TradeCategories { get; set; }

        public Trade(double value, eClientSector clientSector)
        {
            ClientSector = clientSector;
            Value = value;
        }
        public enum eClientSector
        {
            Public,
            Private
        }
        public enum eTradeCategories
        {
            LOWRISK,
            MEDIUMRISK,
            HIGHRISK,
            NOT_APPLICABLE
        }
    }
}
